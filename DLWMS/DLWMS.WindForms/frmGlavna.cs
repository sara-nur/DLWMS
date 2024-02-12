using DLWMS.WindForms.Studenti;

namespace DLWMS.WindForms.P5___Prijava
{
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void studentiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var studentiPretraga = new Studenti.frmStudentiPretraga();
            // studentiPretraga.MdiParent = this;
            studentiPretraga.Show();
        }

        private void krajRadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
