using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Net.Mime;

namespace DLWMS.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojIndeksa { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public int GodinaStudija { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public byte[] Slika { get; set; }  //postaje niz byte []
        public bool Aktivan { get; set; }
        //public int SpolId { get; set; }
        public Spol Spol { get; set; }
        public List<StudentPredmet> PolozeniPredmeti { get; set; }

        public ICollection<Uloga> Uloga { get; set; }
        public Student()
        {
            PolozeniPredmeti = new List<StudentPredmet>();
            Uloga = new HashSet<Uloga>();

        }
        public override string ToString()
        {
            return $"({BrojIndeksa}) {Ime} {Prezime}";
        }
    }

}
