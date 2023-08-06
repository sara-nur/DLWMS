using DLWMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.ConsoleApp.Predavanja.P2
{
    public class MainP2
    {
        public static void Pokreni()
        {
            //KonekcijaNaBazu();
            VrijednostiReference ();
        }

        private static void VrijednostiReference( )
        {
            int a = new int ();
            int b = a;

            b = 20;

            Student student1 = new Student ()
            {
                Prezime = "Music" ,
                GodinaStudija = 1,
            };
            Student student2 = student1;
            //student1 i student2 posjeduju referencu na jedan te isti objekat
            Console.WriteLine(student1);
            Console.WriteLine(student2);
            student2.Prezime = "Modifikacija prezimena";
            Console.WriteLine(student1);
            Console.WriteLine(student2);
        }

        private static void KonekcijaNaBazu()
        {
            Konekcija konekcija = new Konekcija();
            List<Student> studenti = konekcija.GetStudentByGodinaStudija(1);
            foreach (var student in studenti)
            {
                Console.WriteLine(student);
            }

        }
    }
    
}
