using DLWMS.Data.Helpers;

namespace DLWMS.ConsoleApp.Predavanja.P2
{
    public class MainP2
    {

        public static void Pokreni( )
        {
            //KonekcijaNaBazu();
            //VrijednostiReference ();
            //Nizovi ();
            //PodrazumijevaneVrijednosti ();
            //ProvjeraNullVrijednosti ();
            //SlanjeParametara ();
            //Imutabilnost ();
            //Dekonstrukcija ();
            //Params ();
            Indekseri ();
        }

        private static void Indekseri( )
        {
            var obj = new _Student ()
            {
                GodinaStudija = 1 ,
                MentorId = null ,
                Prezime = "Prezime" ,
            };

            obj[0] = 6;  //idemo na lokaciju 0, a value ce biti 6
        }

        private static void Params( )
        {
            int suma = Sumiraj (2 , 35 , 8 , 6);
            int suma2 = Sumiraj (2 , 35 , 8 , 6 , 34);
            Console.WriteLine (suma);
            Console.WriteLine (suma2);

            var tekst = string.Join ("+" , 2 , 35 , 8 , 6 , 34);

            Console.WriteLine (tekst);
        }

        private static int Sumiraj( params int[] niz )
        {
            var suma = 0;
            for( int i = 0; i < niz.Length; i++ )
                suma += niz[i];
            return suma;
        }

        private static int Sumiraj2( params int[] niz )
        {
            return niz.Sum ();
        }

        private static void Dekonstrukcija( )
        {
            _Student obj = new _Student ()
            {
                GodinaStudija = 1 ,
                MentorId = null ,
                Prezime = "Prezime" ,
            };

            string prezime;
            int godinaStudija;
            obj.Deconstruct (out prezime , out godinaStudija);

            (prezime, godinaStudija) = obj;
        }

        private static void Imutabilnost( )
        {
            string ime = "Denis";
            ime = ime.ToUpper ();
            Console.WriteLine (ime);

            DateTime danas = DateTime.Now;
            danas = danas.AddDays (2);
            Console.WriteLine (danas.ToString ("dd.MM.yyyy"));
        }

        private static void SlanjeParametara( )
        {
            _Student student = new _Student ();
            InicijalizujStudenta (in student);
            Console.WriteLine (student.Prezime);

        }

        private static void InicijalizujStudenta( in _Student obj )
        {
            obj.Prezime = "Prezime32";
        }

        private static void ProvjeraNullVrijednosti( )
        {
            Konekcija konekcija = new Konekcija ();
            _Student student = konekcija.GetStudentByIndeks ("IB210012");
            //if( student != null )
            //{
            //    Console.WriteLine (student.Prezime);
            //}

            Console.WriteLine (student?.Prezime);


        }

        private static void PodrazumijevaneVrijednosti( )
        {
            int a = new int ();
            int b = 0;


            _Student marko = new _Student ()
            {
                Prezime = "Neko" ,
                GodinaStudija = 1 ,
                MentorId = null ,
            };
        }

        private static void Nizovi( )
        {
            _Student[] studenti = new _Student[3];

            for( int i = 0; i < studenti.Length; i++ )
            {
                studenti[i] = new _Student ();
                studenti[i].Prezime = $"Prezime{i}";
                studenti[i].GodinaStudija = i + 1;
                Console.WriteLine (studenti[i]);
            }


            DLStudent[] dlStudenti = new DLStudent[3];
            for( int i = 0; i < dlStudenti.Length; i++ )
            {
                dlStudenti[i].Prezime = $"Prezime{i}";
                dlStudenti[i].GodinaStudija = i + 1;
                Console.WriteLine (dlStudenti[i]);
            }

        }

        private static void VrijednostiReference( )
        {
            int a = new int ();
            int b = a;

            b = 20;

            _Student student1 = new _Student ()
            {
                Prezime = "Music" ,
                GodinaStudija = 1 ,
            };
            _Student student2 = student1;
            //student1 i student2 posjeduju referencu na jedan te isti objekat
            Console.WriteLine (student1);
            Console.WriteLine (student2);
            student2.Prezime = "Modifikacija prezimena Studenta 2";
            Console.WriteLine (student1);
            Console.WriteLine (student2);

            Console.WriteLine ("------------------------------");

            DLStudent dlStudent1 = new DLStudent ()
            {
                Prezime = "Music" ,
                GodinaStudija = 1 ,
            };

            DLStudent dlStudent2 = dlStudent1;

            Console.WriteLine (dlStudent1);
            Console.WriteLine (dlStudent2);
            dlStudent2.Prezime = "Modifikacija DL Studenta 2";
            Console.WriteLine (dlStudent1);
            Console.WriteLine (dlStudent2);



        }

        private static void KonekcijaNaBazu( )
        {
            Konekcija konekcija = new Konekcija ();
            List<_Student> studenti = konekcija.GetStudentByGodinaStudija (1);
            foreach( var student in studenti )
            {
                Console.WriteLine (student);
            }

        }
    }

}
