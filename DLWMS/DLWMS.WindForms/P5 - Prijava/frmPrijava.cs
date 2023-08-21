using DLWMS.Data;
using DLWMS.WindForms.Helpers;

namespace DLWMS.WindForms.P5___Prijava
{
    public partial class frmPrijava : Form
    {
        public frmPrijava( )
        {
            InitializeComponent ();
        }

        private void btnPrijava_Click( object sender , EventArgs e )
        {
            var korisnickoIme = txtKorisnickoIme.Text;
            var lozinka = txtLozinka.Text;

            //Prvo vrsimo validaciju unosa, dakle korisniku govorimo da mora unijeti podatke u odredjena polja
            if( ValidanUnos () )
            {
                foreach( var korisnik in InMemoryDB.Korisnici )
                {
                    if( korisnickoIme == korisnik.KorisnickoIme &&
                        lozinka == korisnik.Lozinka )
                    {
                        if( korisnik.Aktivan )
                        {

                            MessageBox.Show ($"{Resursi.Get (Kljucevi.DobroDosli)}{korisnik}" ,
                                            Resursi.Get (Kljucevi.Informacija) ,
                                            MessageBoxButtons.OK ,
                                            MessageBoxIcon.Information);
                            DLWMSApp.Korisnik = korisnik;
                            //TODO: Close frmPrijava
                            new frmGlavna ().Show ();

                        }
                        else
                            MessageBox.Show ($"{korisnik} ,{Resursi.Get (Kljucevi.NalogNijeAktivan)}" ,
                                           Resursi.Get (Kljucevi.Informacija) ,
                                           MessageBoxButtons.OK ,
                                           MessageBoxIcon.Warning);
                        // MessageBox.Show ( string.Format(Resursi.Get (Kljucevi.NalogNijeAktivan),korisnik)) ;
                        return;

                    }
                }

                MessageBox.Show (string.Format (Resursi.Get (Kljucevi.PodaciNisuValidni)));
            }
        }

        private bool ValidanUnos( )
        {
            return Validator.ValidirajKontrolu (txtKorisnickoIme , err , Kljucevi.ObaveznaVrijednost) &&
                   Validator.ValidirajKontrolu (txtLozinka , err , Kljucevi.ObaveznaVrijednost);
        }

        private void linkLabel1_LinkClicked( object sender , LinkLabelLinkClickedEventArgs e )
        {
            //TODO: Close form instead of hiding it 
            Hide ();
            new frmRegistracija ().Show ();
        }
    }
}
