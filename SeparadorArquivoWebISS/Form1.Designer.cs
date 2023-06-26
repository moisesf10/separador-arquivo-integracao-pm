namespace SeparadorArquivoWebISS
{
	partial class FrmPrincipal
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.WindowState = FormWindowState.Maximized;
			menuStrip1 = new MenuStrip();
			menuToolStripMenuItem = new ToolStripMenuItem();
			menuDesmembrarArquivoEmLotesToolStripMenuItem = new ToolStripMenuItem();
			menuSepararGuiaToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(877, 28);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuDesmembrarArquivoEmLotesToolStripMenuItem, menuSepararGuiaToolStripMenuItem });
			menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			menuToolStripMenuItem.Size = new Size(60, 24);
			menuToolStripMenuItem.Text = "Menu";
			// 
			// menuDesmembrarArquivoEmLotesToolStripMenuItem
			// 
			menuDesmembrarArquivoEmLotesToolStripMenuItem.Name = "menuDesmembrarArquivoEmLotesToolStripMenuItem";
			menuDesmembrarArquivoEmLotesToolStripMenuItem.Size = new Size(298, 26);
			menuDesmembrarArquivoEmLotesToolStripMenuItem.Text = "Desmembrar Arquivo Em Lotes";
			menuDesmembrarArquivoEmLotesToolStripMenuItem.Click += cortarArquivoEmLotesToolStripMenuItem_Click;
			// 
			// menuSepararGuiaToolStripMenuItem
			// 
			menuSepararGuiaToolStripMenuItem.Name = "menuSepararGuiaToolStripMenuItem";
			menuSepararGuiaToolStripMenuItem.Size = new Size(298, 26);
			menuSepararGuiaToolStripMenuItem.Text = "Separar Guia";
			// 
			// FrmPrincipal
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(877, 470);
			Controls.Add(menuStrip1);
			IsMdiContainer = true;
			MainMenuStrip = menuStrip1;
			Name = "FrmPrincipal";
			Text = "Separador de Arquivos";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem menuToolStripMenuItem;
		private ToolStripMenuItem menuDesmembrarArquivoEmLotesToolStripMenuItem;
		private ToolStripMenuItem menuSepararGuiaToolStripMenuItem;
	}
}