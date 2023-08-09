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
            Interfejsi();

        }

        private static void Interfejsi()
        {
                  //sada mozemo da kreiramo korisnika2 tipa IKorisnik koji pokazuje na DLStudenta iako DLStudent ne inpmentira interface IKorisnik vec Istudent. Ovo je moguce jer interface IStudent nasljedjuje interface IKorisnik 
             IKorisnik korisnik = new Korisnik();
             IKorisnik dlStudent = new DLStudent("IB234532", "Denis", "Mare" );

                  PrijaviKorisnika(korisnik);
                  PrijaviKorisnika(dlStudent);
        }

        private static void PrijaviKorisnika(IKorisnik korisnik)
        {
            korisnik.Prijava();
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

    public interface IKorisnik
    {
        string KorisnickoIme { get; set; }
        string Lozinka { get; set; }
        bool Prijava();
    }                           

    public interface IStudent
    {
        bool PrijaviIspit();
    }

    public class Korisnik : IKorisnik
    {
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public bool Prijava( )
        {
            Console.WriteLine("KORISNIK se prijavljuje... ");
            return true;
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

    public class DLStudent : Osoba, IKorisnik, IStudent
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


        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public bool Prijava()
        {
            Console.WriteLine ("DLStudent se prijavljuje... ");
            return true;
        }
        public bool PrijaviIspit()
        {
            throw new NotImplementedException();
        }
    }

}
