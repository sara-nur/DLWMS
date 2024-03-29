﻿using DLWMS.Data;
using DLWMS.WindForms.Helpers;

namespace DLWMS.WindForms.P5___Prijava
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
            txtLozinka.Text = Generator.GenerisiLozinku (20);
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
                MessageBox.Show (Resursi.Get (Kljucevi.UspjesnaRegistracija));

                new frmPrijava ().Show ();
                Close ();
                InMemoryDB.Korisnici.Add (noviKorisnik);


            }

        }

        private bool ValidanUnos( )
        {
            return
                Validator.ValidirajKontrolu (txtIme , errPr , Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu (txtPrezime , errPr , Kljucevi.ObaveznaVrijednost) &&
                Validator.ValidirajEmail (txtEmail , errPr , Kljucevi.EmailVecPostoji);
        }



    }
}
