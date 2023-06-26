using SeparadorArquivoWebISS.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SeparadorArquivoWebISS.Forms
{
	public partial class FrmDesmembrarEmLote : Form
	{
		private string fileName = null;
		private string filePath = null;
		private int totalRegistrosProcessar = 0;
		public FrmDesmembrarEmLote()
		{
			InitializeComponent();
		}

		private void textboxArquivoConversao_TextChanged(object sender, EventArgs e)
		{

		}

		private void textboxArquivoConversao_Click(object sender, EventArgs e)
		{
			DialogResult result = openFileDialog1.ShowDialog();
			if (result == DialogResult.OK) // Test result.
			{
				textboxArquivoConversao.Text = openFileDialog1.FileName;
				fileName = System.IO.Path.GetFileName(openFileDialog1.FileName);
				filePath = openFileDialog1.FileName;

				Dictionary<string, int> counters = Interpreter.GetFileCounter(filePath);

				string infos = "";
				totalRegistrosProcessar = 0;

				foreach (var item in counters)
				{
					infos += "Código " + item.Key + ": " + Convert.ToString(item.Value) + " registros; \r\n";
					totalRegistrosProcessar += item.Value;
				}

				#region
				// adiciona mais 1 relacionado ao reg 000
				if (totalRegistrosProcessar > 0)
				{
					totalRegistrosProcessar += 1;
				}
				#endregion


				labelInfos.Text = infos;

			}
		}

		private async void buttonProcessar_Click(object sender, EventArgs e)
		{
			if (
				 String.IsNullOrEmpty(textboxArquivoConversao.Text.Trim()) ||
				 String.IsNullOrEmpty(textBoxDiretorioSave.Text.Trim()) ||
				 String.IsNullOrEmpty(textBoxCodigoRegistro.Text.Trim()) ||
				 String.IsNullOrEmpty(textBoxQuantidadeLote.Text.Trim()) ||
				 (!radioButtonAgruparSim.Checked && !radioButtonAgruparNao.Checked)
				)
			{
				MessageBox.Show("Todos os campos são de preenchimento obrigatório");
				return;
			}

			var progress = new Progress<ReportProgress>(report =>
			{


				if (report.IsComputed)
				{
					var percent = ((decimal)report.AtualReg / (decimal)(report.TotalReg ?? totalRegistrosProcessar) * 100);
					if (percent > 99)
					{
						progressBar1.Value = 100;
					}
					else
					{
						if (percent < 0)
						{
							progressBar1.Value = 0;
						}
						else
						{
							progressBar1.Value = (int)percent;
						}
					}
					lbProgress.Text = (report.Message ?? "") + " - " + Convert.ToString(report.AtualReg) + "/" +
							Convert.ToString(report.TotalReg ?? totalRegistrosProcessar);
				}
				else
				{
					lbProgress.Text = report.Message ?? "";
				}

			});

			List<string> newsFiles = await Interpreter.DesmemberFile(
				filePath: textboxArquivoConversao.Text,
				folderPath: textBoxDiretorioSave.Text,
				codRegister: textBoxCodigoRegistro.Text,
				loteSize: int.Parse(textBoxQuantidadeLote.Text),
				progress: progress,
				indicatesOrder: (radioButtonAgruparSim.Checked) ? true : false
			);

			if (newsFiles.Count < 1)
			{
				MessageBox.Show("Nenhum arquivo de desmembramento foi gerado");
			}
			else
			{
				string files = "";
				foreach (string fileName in newsFiles)
				{
					files += "- " + fileName + "\r\n";
				}
				textBoxNomesArquivos.Text = files;
				MessageBox.Show("Arquivo processado com sucesso!");
			}

		}

		private void textBoxDiretorioSave_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				textBoxDiretorioSave.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private void textBoxCodigoRegistro_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
			{
				e.Handled = true;
			}
		}

		private void textBoxQuantidadeLote_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
			{
				e.Handled = true;
			}
		}
	}
}
