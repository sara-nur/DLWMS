using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection;
using System.Resources;
using static DLWMS.WindForms.Helpers.Kljucevi;

namespace DLWMS.WindForms.Helpers
{
    public class Resursi
    {
        private static ResourceManager _menadzer = new (NazivResourceFajla , Assembly.GetExecutingAssembly ());

        public static string Get( string kljuc )
        {
            return _menadzer.GetString (kljuc);
        }
    }
}

