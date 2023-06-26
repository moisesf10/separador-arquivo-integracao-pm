namespace SeparadorArquivoWebISS.Forms
{
	partial class FrmConfirmDialog
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
			panel1 = new Panel();
			label1 = new Label();
			buttonDialogResultOk = new Button();
			buttonDialogResultCancel = new Button();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.AutoSize = true;
			panel1.BackColor = Color.FromArgb(255, 192, 192);
			panel1.Controls.Add(buttonDialogResultCancel);
			panel1.Controls.Add(buttonDialogResultOk);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(800, 157);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.Dock = DockStyle.Top;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Padding = new Padding(0, 15, 0, 0);
			label1.Size = new Size(800, 96);
			label1.TabIndex = 0;
			label1.Text = "O diretório contém arquivos salvos, continuar com o processo fará com que os mesmos sejam substituídos. Deseja continuar?";
			label1.TextAlign = ContentAlignment.TopCenter;
			// 
			// buttonDialogResultOk
			// 
			buttonDialogResultOk.DialogResult = DialogResult.OK;
			buttonDialogResultOk.Location = new Point(539, 116);
			buttonDialogResultOk.Name = "buttonDialogResultOk";
			buttonDialogResultOk.Size = new Size(112, 29);
			buttonDialogResultOk.TabIndex = 1;
			buttonDialogResultOk.Text = "Continuar";
			buttonDialogResultOk.UseVisualStyleBackColor = true;
			// 
			// buttonDialogResultCancel
			// 
			buttonDialogResultCancel.DialogResult = DialogResult.Cancel;
			buttonDialogResultCancel.Location = new Point(657, 116);
			buttonDialogResultCancel.Name = "buttonDialogResultCancel";
			buttonDialogResultCancel.Size = new Size(94, 29);
			buttonDialogResultCancel.TabIndex = 2;
			buttonDialogResultCancel.Text = "Cancelar";
			buttonDialogResultCancel.UseVisualStyleBackColor = true;
			// 
			// FrmConfirmDialog
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 157);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.SizableToolWindow;
			Name = "FrmConfirmDialog";
			Text = "Confirmar";
			panel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Button buttonDialogResultCancel;
		private Button buttonDialogResultOk;
	}
}