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
using DLWMS.WindForms.Helpers;

namespace DLWMS.WindForms.Studenti
{
    public partial class frmStudentiNovi : Form
    {
        public frmStudentiNovi( )
        {
            InitializeComponent ();
        }

        private void groupBox2_Enter( object sender , EventArgs e )
        {

        }

        private void label2_Click( object sender , EventArgs e )
        {

        }

        private void textBox1_TextChanged( object sender , EventArgs e )
        {
        }

        private void btnSacuvaj_Click( object sender , EventArgs e )
        {
            if( ValidanUnos () )
            {

            }
        }

        private bool ValidanUnos( )
        {
            return Validator.ValidirajKontrolu (txtIme , err , Kljucevi.ObaveznaVrijednost) &&
                   Validator.ValidirajKontrolu (txtPrezime , err , Kljucevi.ObaveznaVrijednost) &&
                   Validator.ValidirajKontrolu (cbGodinaStudija , err , Kljucevi.ObaveznaVrijednost) &&
                   Validator.ValidirajKontrolu (txtBrojIndeksa , err , Kljucevi.ObaveznaVrijednost) &&
                   Validator.ValidirajKontrolu (txtEmail , err , Kljucevi.EmailVecPostoji) &&
                   Validator.ValidirajKontrolu (pbSlikaStudenta , err , Kljucevi.ObaveznaVrijednost);
        }

        private void frmStudentiNovi_Load( object sender , EventArgs e )
        {
            UcitajGodinuStudija ();
        }

        private void UcitajGodinuStudija( )
        {
            cbGodinaStudija.DataSource = InMemoryDB.GodineStudija;
            cbGodinaStudija.DisplayMember = "Oznaka";
            cbGodinaStudija.ValueMember = "Oznaka";
        }
    }


}
