using DLWMS.Data;

namespace DLWMS.WindForms.Helpers
{
    public class Validator
    {
        public static bool ValidirajKontrolu( Control kontrola , ErrorProvider err , string kljuc )
        {
            var valid = true;

            if( kontrola is TextBox && string.IsNullOrWhiteSpace (kontrola.Text) )
                valid = false; //validacija nije validna ako uslov nije ispunjen

            else if( kontrola is ComboBox && ( kontrola as ComboBox ).SelectedIndex < 0 )
                valid = false;
            else if( kontrola is PictureBox && ( kontrola as PictureBox ).Image == null )
                valid = false;

            if( !valid )
                err.SetError (kontrola , Resursi.Get (kljuc));
            else
                err.Clear ();
            return valid;
        }
        public static bool ValidirajEmail( TextBox textBox , ErrorProvider errPr , string kljuc )
        {
            foreach( var korisnik in InMemoryDB.Korisnici )
            {
                if( korisnik.Email == textBox.Text )
                {
                    errPr.SetError (textBox , Resursi.Get (kljuc));
                    return false;
                }
            }
            errPr.Clear ();
            return true;
        }
    }
}

