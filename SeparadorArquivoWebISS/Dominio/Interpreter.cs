using SeparadorArquivoWebISS.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparadorArquivoWebISS.Dominio
{
	internal static class Interpreter
	{
		private static Dictionary<string, List<object>> registers = null;

		public static Dictionary<string, int> GetFileCounter(string filePath) {

			Dictionary<string, int> itens = new Dictionary<string, int>();
			

			using var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			using var sr = new StreamReader(fs, Encoding.UTF8);

			string line = String.Empty;

			while ((line = sr.ReadLine()) != null)
			{
				object row = Explode<object>(line);
				
				if (row != null)
				{
					switch (row.GetType().Name)
					{
						case "Reg300":
							var reg300 = (Reg300)row;
							if (! itens.ContainsKey("300"))
							{
								itens.Add("300", 1);
							}
							else
							{
								itens["300"] = itens["300"] + 1;
							}
							break;
						case "Reg330":
							var reg330 = (Reg330)row;
							if (!itens.ContainsKey("330"))
							{
								itens.Add("330", 1);
							}
							else
							{
								itens["330"] = itens["330"] + 1;
							}
							break;
						case "Reg340":
							var reg340 = (Reg340)row;
							if (!itens.ContainsKey("340"))
							{
								itens.Add("340", 1);
							}
							else
							{
								itens["340"] = itens["340"] + 1;
							}
							break;
					}
				}
			}
			return itens;
		}


		public static T Explode<T>(string line) where T : class
		{

			string[] columns = line.Split('|');

			if(columns.Length < 1 ) {
				return null;
			}

			dynamic reg = null;
			switch(columns[1])
			{
				case "000":
					reg = new Reg000();
					reg.Registro = line;
					reg.NumLinhaOriginal = int.Parse(columns[0]) ;
					reg.CodRegistro = columns[1];
					reg.Nome = columns[2];
					reg.CodigoMunicipioIbge = columns[3];
					reg.DataInicialColeta = columns[4];
					reg.DataFinalColeta = columns[5];
					reg.DataGeracaoArquivo = columns.ElementAtOrDefault(6);
					return (T)(object)reg;
				case "300":
					reg = new Reg300();
					reg.Registro = line;
					reg.NumLinhaOriginal = int.Parse(columns[0]);
					reg.CodRegistro = columns[1];
					reg.NumDocumento = columns[2] ?? null;
					reg.Inscricao = columns[3] ?? null;
					reg.TributoId = columns[4] ?? null;
					reg.SituacaoDebito = columns[5] ?? null;
					reg.NumDocumentoUsuarioCriacao = columns[6] ?? null;
					reg.MoedaId = columns[7] ?? null;
					reg.NumeroOrigemLancamento = columns[8] ?? null;
					reg.IdOrigemLancamento = columns[9] ?? null;
					reg.DtCriacao = columns[10] ?? null;
					reg.DtVencimento = columns[11] ?? null;
					reg.AnoCompetencia = columns[12] ?? null;
					reg.AnoLancamento = columns[13] ?? null;
					reg.MesCompetencia = columns[14] ?? null;
					reg.MesCompetencia = columns[15] ?? null;
					reg.VlrResidual = columns[16] ?? null;
					reg.OrigemLancamento = columns[17] ?? null;
					reg.IndicaInscritoDat = columns[18] ?? null;
					reg.ObservacaoDebito = columns[19] ?? null;
					reg.IdDebito = columns[20] ?? null;
					reg.DtCancelamento = columns[21] ?? null;
					reg.JustificativaCancelamento = columns[22] ?? null;
					reg.NumDocumentoUsuarioCancelamento = columns[23] ?? null;
					reg.IdLancamentoLegado = columns[24] ?? null;
					return (T) (object) reg;
				case "330":
					reg =  new Reg330();
					reg.Registro = line;
					reg.NumLinhaOriginal = int.Parse(columns[0]);
					reg.CodRegistro = columns[1];
					reg.IdDebito = columns[4] ?? null;
					reg.NossoNumeroGuia = columns[19] ?? null;
				
					return (T)(object)reg;
				case "340":
					reg = new Reg340();
					reg.Registro = line;
					reg.NumLinhaOriginal = int.Parse(columns[0]);
					reg.CodRegistro = columns[1];

					return (T)(object)reg;
				default: 
					reg = null;
				break;
			}

			return reg;

		}


		public static async Task<List<string>> DesmemberFile(IProgress<ReportProgress> progress, string filePath, string folderPath, string codRegister, int loteSize, bool indicatesOrder = false)
		{
			await loadFile(filePath, codRegister, progress);
			#region
			// Ordenação
			if (indicatesOrder)
			{
				progress.Report(new ReportProgress {IsComputed = false, Message = "Ordenando registros..." });
				
				if(registers.ContainsKey(codRegister))
				{
					List<object> orderedList = new List<object>(); 
					switch(codRegister)
					{
						case "300":
							orderedList = registers[codRegister].OrderBy(x => x.GetType().GetProperties().First(o => o.Name == "NumDocumento").GetValue(x)  ).ToList();
							registers[codRegister] = orderedList;
							break;
						case "330":
							orderedList = registers[codRegister].OrderBy(x => x.GetType().GetProperties().First(o => o.Name == "NossoNumeroGuia").GetValue(x)).ToList();
							registers[codRegister] = orderedList;
							break;
						case "340":
							orderedList = registers[codRegister].OrderBy(x => x.GetType().GetProperties().First(o => o.Name == "NossoNumeroGuia").GetValue(x)).ToList();
							registers[codRegister] = orderedList;
							break;
					}
				}
			}
			#endregion

			if(!Directory.Exists(folderPath))
			{
				Directory.CreateDirectory(folderPath);
			}

			List<string> newsFiles = new List<string>();

			if (registers[codRegister] != null && registers[codRegister].Count > 0) {
				progress.Report(new ReportProgress { TotalReg = 1, AtualReg = 0, Message = "" }); // zera barra de prograsso
				#region
				string[] dirFiles = System.IO.Directory.GetFiles(folderPath)  ;
				if(Array.Exists(dirFiles, x => x.Contains("Reg" + codRegister + "_Part" )))
				{
					progress.Report(new ReportProgress { IsComputed = false, Message = "Preparando para criar novos arquivos" });
					FrmConfirmDialog dialog = new FrmConfirmDialog();
					if (dialog.ShowDialog() == DialogResult.OK)
					{
						foreach(string f in dirFiles)
						{
							try
							{
								// Check if file exists with its full path
								if (f.Contains("Reg"+ codRegister + "_Part") && File.Exists(f))
								{
									// If file found, delete it
									File.Delete(f);
								}
							}
							catch (IOException ioExp)
							{
								Console.WriteLine(ioExp.Message);
								throw;
							}
						}
					}
					else
					{
						return new List<string>() ;
					}
				}
				#endregion

				int pageNumber = 0;
				int cont = 0;
				bool startPage = true;
				
				string globalCompareValue = "";
				
				List<object> rows = registers[codRegister];


				StreamWriter writer = null;
				int i = 0;
				foreach (var row in rows)
				{
					#region
					// progress report
					i++;
					if(i % 40 == 0)
					{
						progress.Report(new ReportProgress { TotalReg = rows.Count,  AtualReg = i, Message = "Separando registros" });
					}
					#endregion

					string newRow = "";
					string localCompareValue = ""; // utilizado para verificar se o valor de agrupamento da linha anterior é igual a atual
					switch (row.GetType().Name)
					{
						case "Reg300":
							Reg300 reg300 = (Reg300)row;
							newRow = reg300.Registro;
							localCompareValue = reg300.NumDocumento;
							break;
						case "Reg330":
							Reg330 reg330 = (Reg330)row;
							newRow = reg330.Registro;
							localCompareValue = reg330.NossoNumeroGuia;
							break;
						case "Reg340":
							Reg340 reg340 = (Reg340)row;
							newRow = reg340.Registro;
							localCompareValue = reg340.NossoNumeroGuia;
							break;
					}


					if (indicatesOrder)
					{
						if(localCompareValue != globalCompareValue)
						{
							cont++;
						}
					}
					else
					{
						cont++;
					}
					globalCompareValue = localCompareValue;


					if (cont >= loteSize)
					{
						startPage = true;
						cont = 0;
					}


					if (startPage)
					{
						if(writer != null) writer.Close();
						string newFileName = String.Concat("Reg", codRegister, "_Part", Convert.ToString(++pageNumber), ".txt" );
						writer = new StreamWriter(Path.Combine(folderPath, newFileName));
						Reg000 reg000 = (Reg000) registers["000"][0]  ;
						writer.WriteLine(reg000.Registro);
						newsFiles.Add(newFileName);
						startPage = false;
					}
					//startPage = false;

					writer.WriteLine(newRow);

				}
				
				if(writer != null) writer.Close();
			
			}

			progress.Report(new ReportProgress { IsComputed = false, Message = "Processamento finalizado!" });
			return  newsFiles;
		}

		private static async Task loadFile(string filePath, string codRegister, IProgress<ReportProgress> progress)
		{
			progress.Report( new ReportProgress { AtualReg = 0, Message = "Carregando arquivo" });
			registers = new Dictionary<string, List<object>>();

			using var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			using var sr = new StreamReader(fs, Encoding.UTF8);

			string line = String.Empty;

			int cont = 0;
			while ((line = sr.ReadLine()) != null)
			{
				cont++;

				if(cont % 40 == 0)
				{
					progress.Report(new ReportProgress { AtualReg = cont, Message = "Carregando arquivo" });
					//Task.Delay(100).Wait();
					
				}

				object row = Explode<object>(line);

				if (row != null)
				{
					string searchClassName = String.Concat("Reg", codRegister);
					if (row.GetType().Name == "Reg000")
					{
						if(!registers.ContainsKey("000"))
						{
							registers.Add("000", new List<object> { row }  );
						}
						else
						{
							registers["300"].Add(row);
						}
					}
					else
					{
						if (row.GetType().Name.Equals(searchClassName))
						{
							if (!registers.ContainsKey(codRegister))
							{
								registers.Add(codRegister, new List<object> { row });
							}
							else
							{
								registers[codRegister].Add(row);
							}
						}
					}

					
				}
			}
			progress.Report(new ReportProgress { AtualReg = cont, Message = "Carregando arquivo" });
		}

	}
}
