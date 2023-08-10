using DLWMS.Data;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.ConsoleApp.Predavanja.P3
{
    internal class MainP3
    {
        private static ILogger _logger;
        public static void Pokreni(ILogger logger )
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

    public interface IRepository<T>
    {
        T GetById(int id);
        void Save(T Entity);
        void Delete(T Entity);
    }

    public class Repository<T> :IRepository<T>
    {
        public T GetById(int id)
        {
            return  default(T);
        }

        public void Save(T Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T Entity)
        {
            throw new NotImplementedException();
        }
    }

    public class StudentRepository  :Repository<Student> { }

    public class KorisnikRepository :Repository<Korisnik>


    public interface ILogger
    {
        void Log(object message);
    }

    // Baza podataka
    public class DBLogger : ILogger
    {
        private const string Putanja = "Server = 192.168.1.10;MyDataBase = DLWMS";

        public void Log(object message)
        {
            Console.WriteLine($"DBLog -> {Putanja}\nData-> {DataExtractor.GetData(message)}");
        }
    }

    // File Loger
    public class FileLogger : ILogger
    {
        private const string Putanja = @"c:\logs\dlwms_log.txt";

        public void Log( object message )
        {
            Console.WriteLine ($"FileLog -> {Putanja}\nData-> {DataExtractor.GetData (message)}");
        }
    }

    // Web servis - API
    public class WebServisLogger : ILogger
    {
        private const string Putanja = @"uri:log.fit.ba;token: 321321-sdf1312sdf0";

        public void Log( object message )
        {
            Console.WriteLine ($"WebServisLog -> {Putanja}\nData-> {DataExtractor.GetData (message)}");
        }
    }

    public class DataExtractor
    {
        public static string GetData(object message)
        {
            if (message == null) return string.Empty; //ukoliko je null vrati prazan string
            if (message is Exception) 
                return (message as Exception).Message;   //ukoliko je exception prikazi exceotion poruku 
            return message.ToString();     //ukoliko nije nijedno, vrati poruku 
        }
    }
    
}
