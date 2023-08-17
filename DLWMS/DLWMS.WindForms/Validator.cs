using DLWMS.Data;

namespace DLWMS.WindForms;

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