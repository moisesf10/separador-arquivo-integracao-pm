namespace SeparadorArquivoWebISS.Forms
{
	partial class FrmDesmembrarEmLote
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDesmembrarEmLote));
			label1 = new Label();
			groupBox1 = new GroupBox();
			label7 = new Label();
			textBoxDiretorioSave = new TextBox();
			label2 = new Label();
			textboxArquivoConversao = new TextBox();
			openFileDialog1 = new OpenFileDialog();
			groupBox2 = new GroupBox();
			labelInfos = new Label();
			groupBox3 = new GroupBox();
			buttonProcessar = new Button();
			label6 = new Label();
			label5 = new Label();
			radioButtonAgruparNao = new RadioButton();
			radioButtonAgruparSim = new RadioButton();
			label4 = new Label();
			label3 = new Label();
			textBoxQuantidadeLote = new TextBox();
			textBoxCodigoRegistro = new TextBox();
			folderBrowserDialog1 = new FolderBrowserDialog();
			groupBox4 = new GroupBox();
			lbProgress = new Label();
			progressBar1 = new ProgressBar();
			panelNomesArquivos = new Panel();
			textBoxNomesArquivos = new TextBox();
			contextMenuStrip1 = new ContextMenuStrip(components);
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox4.SuspendLayout();
			panelNomesArquivos.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(311, 19);
			label1.Name = "label1";
			label1.Size = new Size(383, 37);
			label1.TabIndex = 0;
			label1.Text = "Desmembrar Arquivo em Lotes";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(textBoxDiretorioSave);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(textboxArquivoConversao);
			groupBox1.Location = new Point(23, 89);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(877, 212);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Arquivos";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(6, 113);
			label7.Name = "label7";
			label7.Size = new Size(346, 20);
			label7.TabIndex = 3;
			label7.Text = "Selecione o diretório para salvar os novos arquivos";
			// 
			// textBoxDiretorioSave
			// 
			textBoxDiretorioSave.BorderStyle = BorderStyle.FixedSingle;
			textBoxDiretorioSave.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxDiretorioSave.Location = new Point(6, 136);
			textBoxDiretorioSave.Name = "textBoxDiretorioSave";
			textBoxDiretorioSave.PlaceholderText = "Clique aqui e selecione o diretório para salvar os arquivos";
			textBoxDiretorioSave.Size = new Size(768, 30);
			textBoxDiretorioSave.TabIndex = 2;
			textBoxDiretorioSave.Click += textBoxDiretorioSave_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(6, 42);
			label2.Name = "label2";
			label2.Size = new Size(228, 20);
			label2.TabIndex = 1;
			label2.Text = "Carregue o arquivo de conversão";
			// 
			// textboxArquivoConversao
			// 
			textboxArquivoConversao.BorderStyle = BorderStyle.FixedSingle;
			textboxArquivoConversao.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			textboxArquivoConversao.Location = new Point(6, 65);
			textboxArquivoConversao.Name = "textboxArquivoConversao";
			textboxArquivoConversao.PlaceholderText = "Clique aqui para carregar um arquivo";
			textboxArquivoConversao.Size = new Size(768, 30);
			textboxArquivoConversao.TabIndex = 0;
			textboxArquivoConversao.Click += textboxArquivoConversao_Click;
			textboxArquivoConversao.TextChanged += textboxArquivoConversao_TextChanged;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(labelInfos);
			groupBox2.Location = new Point(23, 322);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(877, 119);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			groupBox2.Text = "Informações do Arquivo";
			// 
			// labelInfos
			// 
			labelInfos.AutoSize = true;
			labelInfos.ForeColor = Color.Black;
			labelInfos.Location = new Point(6, 23);
			labelInfos.Margin = new Padding(2);
			labelInfos.Name = "labelInfos";
			labelInfos.Size = new Size(0, 20);
			labelInfos.TabIndex = 0;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(buttonProcessar);
			groupBox3.Controls.Add(label6);
			groupBox3.Controls.Add(label5);
			groupBox3.Controls.Add(radioButtonAgruparNao);
			groupBox3.Controls.Add(radioButtonAgruparSim);
			groupBox3.Controls.Add(label4);
			groupBox3.Controls.Add(label3);
			groupBox3.Controls.Add(textBoxQuantidadeLote);
			groupBox3.Controls.Add(textBoxCodigoRegistro);
			groupBox3.Location = new Point(23, 464);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(871, 208);
			groupBox3.TabIndex = 3;
			groupBox3.TabStop = false;
			groupBox3.Text = "Desmembramento";
			// 
			// buttonProcessar
			// 
			buttonProcessar.Location = new Point(6, 157);
			buttonProcessar.Name = "buttonProcessar";
			buttonProcessar.Size = new Size(186, 36);
			buttonProcessar.TabIndex = 8;
			buttonProcessar.Text = "Processar";
			buttonProcessar.UseVisualStyleBackColor = true;
			buttonProcessar.Click += buttonProcessar_Click;
			// 
			// label6
			// 
			label6.ForeColor = Color.Firebrick;
			label6.Location = new Point(422, 93);
			label6.Name = "label6";
			label6.Size = new Size(426, 80);
			label6.TabIndex = 7;
			label6.Text = resources.GetString("label6.Text");
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(422, 34);
			label5.Name = "label5";
			label5.Size = new Size(197, 20);
			label5.TabIndex = 6;
			label5.Text = "Deseja agrupar os registros?";
			// 
			// radioButtonAgruparNao
			// 
			radioButtonAgruparNao.AutoSize = true;
			radioButtonAgruparNao.Location = new Point(479, 57);
			radioButtonAgruparNao.Name = "radioButtonAgruparNao";
			radioButtonAgruparNao.Size = new Size(58, 24);
			radioButtonAgruparNao.TabIndex = 5;
			radioButtonAgruparNao.TabStop = true;
			radioButtonAgruparNao.Text = "Não";
			radioButtonAgruparNao.UseVisualStyleBackColor = true;
			// 
			// radioButtonAgruparSim
			// 
			radioButtonAgruparSim.AutoSize = true;
			radioButtonAgruparSim.Location = new Point(422, 57);
			radioButtonAgruparSim.Name = "radioButtonAgruparSim";
			radioButtonAgruparSim.Size = new Size(55, 24);
			radioButtonAgruparSim.TabIndex = 4;
			radioButtonAgruparSim.TabStop = true;
			radioButtonAgruparSim.Text = "Sim";
			radioButtonAgruparSim.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(141, 31);
			label4.Name = "label4";
			label4.Size = new Size(204, 20);
			label4.TabIndex = 3;
			label4.Text = "Qtd. de Registros Por Arquivo";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(0, 31);
			label3.Name = "label3";
			label3.Size = new Size(116, 20);
			label3.TabIndex = 2;
			label3.Text = "Cod. do registro";
			// 
			// textBoxQuantidadeLote
			// 
			textBoxQuantidadeLote.BorderStyle = BorderStyle.FixedSingle;
			textBoxQuantidadeLote.Location = new Point(141, 54);
			textBoxQuantidadeLote.MaxLength = 7;
			textBoxQuantidadeLote.Name = "textBoxQuantidadeLote";
			textBoxQuantidadeLote.Size = new Size(221, 27);
			textBoxQuantidadeLote.TabIndex = 1;
			textBoxQuantidadeLote.KeyPress += textBoxQuantidadeLote_KeyPress;
			// 
			// textBoxCodigoRegistro
			// 
			textBoxCodigoRegistro.BorderStyle = BorderStyle.FixedSingle;
			textBoxCodigoRegistro.Location = new Point(6, 54);
			textBoxCodigoRegistro.MaxLength = 3;
			textBoxCodigoRegistro.Name = "textBoxCodigoRegistro";
			textBoxCodigoRegistro.PlaceholderText = "Ex: 300";
			textBoxCodigoRegistro.Size = new Size(112, 27);
			textBoxCodigoRegistro.TabIndex = 0;
			textBoxCodigoRegistro.KeyPress += textBoxCodigoRegistro_KeyPress;
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(lbProgress);
			groupBox4.Controls.Add(progressBar1);
			groupBox4.Controls.Add(panelNomesArquivos);
			groupBox4.Location = new Point(908, 97);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(475, 575);
			groupBox4.TabIndex = 4;
			groupBox4.TabStop = false;
			groupBox4.Text = "Progresso";
			// 
			// lbProgress
			// 
			lbProgress.AutoSize = true;
			lbProgress.Location = new Point(6, 34);
			lbProgress.Name = "lbProgress";
			lbProgress.Size = new Size(0, 20);
			lbProgress.TabIndex = 1;
			// 
			// progressBar1
			// 
			progressBar1.Location = new Point(6, 57);
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(443, 29);
			progressBar1.TabIndex = 0;
			// 
			// panelNomesArquivos
			// 
			panelNomesArquivos.AutoScroll = true;
			panelNomesArquivos.Controls.Add(textBoxNomesArquivos);
			panelNomesArquivos.Location = new Point(6, 119);
			panelNomesArquivos.Name = "panelNomesArquivos";
			panelNomesArquivos.Size = new Size(463, 441);
			panelNomesArquivos.TabIndex = 2;
			// 
			// textBoxNomesArquivos
			// 
			textBoxNomesArquivos.Dock = DockStyle.Fill;
			textBoxNomesArquivos.Location = new Point(0, 0);
			textBoxNomesArquivos.Multiline = true;
			textBoxNomesArquivos.Name = "textBoxNomesArquivos";
			textBoxNomesArquivos.ReadOnly = true;
			textBoxNomesArquivos.Size = new Size(463, 441);
			textBoxNomesArquivos.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.ImageScalingSize = new Size(20, 20);
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(61, 4);
			// 
			// FrmDesmembrarEmLote
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			ClientSize = new Size(1288, 752);
			Controls.Add(groupBox3);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(label1);
			Controls.Add(groupBox4);
			Name = "FrmDesmembrarEmLote";
			Text = "Desmembrar Arquivo";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			panelNomesArquivos.ResumeLayout(false);
			panelNomesArquivos.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private GroupBox groupBox1;
		private Label label2;
		private TextBox textboxArquivoConversao;
		private OpenFileDialog openFileDialog1;
		private GroupBox groupBox2;
		private Label labelInfos;
		private GroupBox groupBox3;
		private TextBox textBoxQuantidadeLote;
		private TextBox textBoxCodigoRegistro;
		private Label label4;
		private Label label3;
		private RadioButton radioButtonAgruparNao;
		private RadioButton radioButtonAgruparSim;
		private Button buttonProcessar;
		private Label label6;
		private Label label5;
		private Label label7;
		private TextBox textBoxDiretorioSave;
		private FolderBrowserDialog folderBrowserDialog1;
		private GroupBox groupBox4;
		private Label lbProgress;
		private ProgressBar progressBar1;
		private Panel panelNomesArquivos;
		private TextBox textBoxNomesArquivos;
		private ContextMenuStrip contextMenuStrip1;
	}
}