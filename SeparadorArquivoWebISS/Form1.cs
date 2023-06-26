using SeparadorArquivoWebISS.Forms;

namespace SeparadorArquivoWebISS
{
	public partial class FrmPrincipal : Form
	{
		public FrmPrincipal()
		{
			InitializeComponent();
		}

		private bool CheckForDuplicateForm(Form newForm)
		{
			bool bValue = false;
			foreach (Form frm in this.MdiChildren)
			{
				if (frm.GetType() == newForm.GetType())
				{
					frm.Activate();
					bValue = true;
				}
			}
			return bValue;
		}

		private void cortarArquivoEmLotesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmDesmembrarEmLote formDesmembrarLote = new FrmDesmembrarEmLote();
			bool frmPresent = CheckForDuplicateForm(formDesmembrarLote);
			if (frmPresent)
				return;
			else if (!frmPresent)
			{
				formDesmembrarLote.MdiParent = this;
				formDesmembrarLote.Show();
				formDesmembrarLote.WindowState = FormWindowState.Maximized;
			}
		}
	}
}