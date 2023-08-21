using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.Data;

namespace DLWMS.WindForms.Studenti
{
    public partial class frmStudentiPretraga : Form
    {
        public frmStudentiPretraga( )
        {
            InitializeComponent ();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudentiPretraga_Load( object sender , EventArgs e )
        {
            UcitajStudente ();
        }

        private void UcitajStudente( )
        {
            dgvStudenti.DataSource = InMemoryDB.Studenti;
        }

        private void dgvStudenti_CellContentClick( object sender , DataGridViewCellEventArgs e )
        {

        }

        private void btnDodajStudenta_Click( object sender , EventArgs e )
        {
            new frmStudentiNovi().Show();
        }
    }
}
