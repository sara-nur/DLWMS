using DLWMS.ConsoleApp.Predavanja.P3.Interface;
using DLWMS.ConsoleApp.Predavanja.P3.Logger;
using DLWMS.ConsoleApp.Predavanja.P3.Repository;
using DLWMS.Data;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLStudent = DLWMS.ConsoleApp.Predavanja.P3.Interface.DLStudent;

namespace DLWMS.ConsoleApp.Predavanja.P3
{
    internal class MainP3
    {
        private static ILogger _logger;
        public static void Pokreni(WebServisLogger logger )
        {
           // Nasljedjivanje();
           // Interfejsi();
            _logger = logger;
            // ono sto smo prihvatili kao objekat koji  je zaduzen za logiranje, mi zelimo da sacuvamo referencu na njega u okviru naseg _loggera
            //Logiranje();
            Repozitori();
            DisposableInterfejs();
        }

        private static void DisposableInterfejs()
        {
            using( var sr = new Korisnik () )
            {

            }

            using (var sr = new StreamReader(""))
            {

            }
        }

        private static void Repozitori()
        {
            StudentRepository studentDB = new StudentRepository();
            Student sara = new Student()
            {
                GodinaStudija = 1,
                Prezime = "Nur",
                MentorId = null,
            };
            studentDB.Save(sara);

            var korisnikDB = new KorisnikRepository();
            Korisnik korisnik = new Korisnik()
            {
                KorisnickoIme = "kori",
                Lozinka = "234",
            };
            korisnikDB.Save(korisnik);
        }

        private static void Logiranje()
        {
            try
            {
                throw new Exception("Namjerni izuzetak...");
            }
            catch (Exception e)
            {
                _logger.Log(e);
            }
        }        

        private static void Interfejsi()
        {
                  //sada mozemo da kreiramo korisnika2 tipa IKorisnik koji pokazuje na DLStudenta iako DLStudent ne inpmentira interface IKorisnik vec Istudent.
                  //Ovo je moguce jer interface IStudent nasljedjuje interface IKorisnik 
             IKorisnik korisnik = new Korisnik();
             IKorisnik dlStudent = new DLStudent("IB234532", "Denis", "Mare" );

                  PrijaviKorisnika(korisnik);
                  PrijaviKorisnika(dlStudent);

            _logger.Log("Savladali smo interfejse...");

        }

        private static void PrijaviKorisnika(IKorisnik korisnik)
        {
            korisnik.Prijava();
            _logger.Log("Korisnik prijavljen...");
        }

        private static void Nasljedjivanje( )
        {
            //Osoba osoba = new Osoba ("Sara" , "Prez");
            var dlStudent = new DLStudent ("IB23543" , "Sara" , "Nur");

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
}
