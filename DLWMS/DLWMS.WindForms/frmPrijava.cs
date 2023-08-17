using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.Data;

namespace DLWMS.WindForms
{
    public partial class frmPrijava : Form
    {
        public frmPrijava( )
        {
            InitializeComponent ();
        }

        private void label1_Click( object sender , EventArgs e )
        {

        }

        private void label1_Click_1( object sender , EventArgs e )
        {

        }

        private void frmPrijava_Load( object sender , EventArgs e )
        {

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
                            new frmGlavna().Show ();

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
    }

    public class DLWMSApp
    {
        public static Korisnik Korisnik;
    }

    public class Validator
    {
        public static bool ValidirajKontrolu( TextBox textBox , ErrorProvider err , string kljuc )
        {
            if( string.IsNullOrWhiteSpace (textBox.Text) )
            {
                err.SetError (textBox , Resursi.Get (kljuc));
                return false;
            }
            err.Clear ();
            return true;
        }
    }

    public class Resursi
    {
        private static ResourceManager Menadzer = new ResourceManager (Kljucevi.NazivResourceFajla , Assembly.GetExecutingAssembly ());

        public static string Get( string kljuc )
        {
            return Menadzer.GetString (kljuc);
        }
    }

    public class Kljucevi
    {
        public const string NazivResourceFajla = "DLWMS.WindForms.Resource1";
        public const string DobroDosli = "DobroDosli";
        public const string NalogNijeAktivan = "NalogNijeAktivan";
        public const string PodaciNisuValidni = "PodaciNisuValidni";
        public const string Informacija = "Informacija";
        public const string ObaveznaVrijednost = "ObaveznaVrijednost";
    }

}
