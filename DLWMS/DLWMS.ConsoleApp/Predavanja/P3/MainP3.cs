using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.ConsoleApp.Predavanja.P3
{
    internal class MainP3
    {
        public static void Pokreni( )
        {
            Nasljedjivanje();

        }

        private static void Nasljedjivanje( )
        {
            //Osoba osoba = new Osoba ("Sara" , "Prez");
            Osoba dlStudent = new DLStudent ("IB23543" , "Sara" , "Nur");

            //OsobaInfo(osoba);
            OsobaInfo(dlStudent);

            
        }

        private static void OsobaInfo(Osoba osoba)
        {
            if( osoba is DLStudent ) // da li je osoba DLStudent 
            {
                var dlStudent = osoba as DLStudent; //osobu posmatramo kao DLStudent
            }
        }
    }

    public class Konfiguracija
    {
        public const string Naziv = "DLWMS";
        public readonly string KonekcijskiString;

        public Konfiguracija(string konekcijskiString)
        {
            KonekcijskiString = konekcijskiString;
        }

    }

    public abstract class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Osoba(string ime, string prezime)
        {
            Ime=ime;
            Prezime=prezime;
        }

        public abstract string PredstaviSe();

        public virtual string Info()
        {
            return $"{Ime} {Prezime}";
        }

    }

    public class DLStudent : Osoba
    {
        public string Indeks { get; set; }

        public DLStudent(string indeks, string ime, string prezime)
            :base(ime,prezime)
        {
            Indeks = indeks;
        }

        public override string PredstaviSe()
        {
            return $"{Indeks} - {Ime} - {Prezime}";
        }

        public override string Info()
        {
            return $"{Indeks} - {base.Info()}";
        }
    }
    

}
