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

namespace DLWMS.WindForms
{
    public partial class frmRegistracija : Form
    {
        public frmRegistracija( )
        {
            InitializeComponent ();

        }

        private void frmRegistracija_Load( object sender , EventArgs e )
        {
            
        }

        private string GenerisiLozinku( int brojZnakova = 10 )
        {
            var generisanaLozinka = "";
            var karakteri = "qwertyuiopasdfghjkl;'zxcvbnm,-1234567890-=QWERTYUIOPASDFGHJKLČĆŽĐŠŠYXCVBNM";
            var rand = new Random ();
            for( int i = 0; i < 10; i++ )
            {
                var lokacija = rand.Next (0 , karakteri.Length);
                generisanaLozinka += karakteri[lokacija];
            }

            return generisanaLozinka;
        }

        private void GenerisiPodatke( )
        {
            var podaci = $"{txtIme.Text}.{txtPrezime.Text}".ToLower ();
            txtKorisnickoIme.Text = podaci;
            txtEmail.Text = $"{podaci}@edu.fit.ba";
        }

        private void txtIme_TextChanged( object sender , EventArgs e )
        {
            GenerisiPodatke ();
        }

        private void txtPrezime_TextChanged( object sender , EventArgs e )
        {
            GenerisiPodatke ();

        }

        private void btnGenerisi_Click( object sender , EventArgs e )
        {
            txtLozinka.Text = GenerisiLozinku (20);
        }

        private void btnRegistracija_Click( object sender , EventArgs e )
        {
            if( ValidanUnos () )
            {
                var noviKorisnik = new Korisnik ()
                {
                    Id = InMemoryDB.Korisnici.Count + 1 ,
                    Aktivan = cbAktivan.Checked ,
                    Ime = txtIme.Text ,
                    Prezime = txtPrezime.Text ,
                    KorisnickoIme = txtKorisnickoIme.Text ,
                    Email = txtEmail.Text ,
                    Lozinka = txtLozinka.Text ,
                };
                MessageBox.Show(Resursi.Get(Kljucevi.UspjesnaRegistracija));
               
                new frmPrijava ().Show ();
                Close ();
                InMemoryDB.Korisnici.Add (noviKorisnik);

                
            }
            
        }

        private bool ValidanUnos( )
        {
            return
                Validator.ValidirajKontrolu(txtIme, errPr, Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtPrezime, errPr, Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajEmail(txtEmail, errPr, Kljucevi.EmailVecPostoji);

        }
        

       
    }
    

}
