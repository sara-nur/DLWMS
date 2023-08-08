using DLWMS.Data;
using System.Threading.Tasks.Dataflow;

namespace DLWMS.ConsoleApp.Predavanja.P1
{
    public class MainP1
    {
        public static void Pokreni()
        {
            //TipoviPodataka ();
            //Pokazivaci ();
            //Klase ();
            //VrsteTipovaPodataka ();
            //BazniTip ();
            //NovaVerzijaMetode ();
        }

        private static void NovaVerzijaMetode()
        {
            Student denis = new Student(12432, "Denis", "Music");
            Console.WriteLine(denis);
            Console.WriteLine(denis.ToString());
        }

        private static void BazniTip()
        {
            int indeks2 = 222000;
            Student denis = new Student(223344, "Denka", "Music");

            object objIndeks = indeks2;
            object objStudent = denis;

            Prikazi(objIndeks);
            Prikazi(denis);      //metoda ce primati object mozemo poslati bilo sta sto je tipa object 
        }

        private static void Prikazi(object objIndeks)
        {
            throw new NotImplementedException();
        }

        private static void VrsteTipovaPodataka()
        {
            int indeks1 = 0;
            int indeks2 = indeks1;

            //vrijednost iz indeksa1 se kopira u indeks2, promjene u jednom se ne reflektuju na drugi 

            /*
            int indeks2 = new int (); //iako imamo ključnu riječ new koja je u C++ značila izlazak sa stack-a i prezlazak na heap, u C# to nije slučaj. Svi primitivni tipovi uglavnom ostaju na stack-u-
            if(indeks1 == 220000 )
            {
                Console.WriteLine();
            }
            if( indeks2 == 220000 )
            {
                Console.WriteLine();
            }
            */

            Student sara = new Student(123432, "Sara", "Nur"); //na heap-u
            Student denis = sara;

            // u objekat denis se pohranjuje adresa objekta sara, promjene na jednom objektu se reflektuju na drugi objekat 
        }

        private static void Klase()
        {
            Student sara = new Student(220022, "Sara", "Nur");
            sara.GetIndeks();
            Console.WriteLine(sara.GetIndeks());
            sara.SetIndeks(334440);
            Console.WriteLine(sara.GetIndeks());
            sara.Prezime = "Test"; // sada ovaj "test" postaje value u našem setter-u
                                   //ukoliko postavimo neka nasa pravila u propertiju prezime

            Student zanin = new Student(indeks: 22343, prezime: "Vojic", ime: "Zanin");
            Student jasmin = new Student()
            {
                Prezime = "Jasminovic",
                GodinaStudija = 1,
            };

            jasmin.Prezime = "Jasminovic";
            jasmin.GodinaStudija = 1;
        }

        private static void Pokazivaci()
        {
            int indeks = 220022;
            unsafe
            {
                int* p = &indeks;
                *p = 220021;
            }
        }

        private static void TipoviPodataka()
        {
            int Indeks = 220022;
            string imePrezime = "Sara Nur";
            bool aktivan = false;
            double skolarina = 2000;

            Console.WriteLine($"{Indeks} je student {imePrezime} aktivan {aktivan} skolarina {skolarina}");
        }
    }
}
