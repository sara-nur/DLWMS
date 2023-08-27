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
        public Image Slika { get; set; }  //postaje niz byte []
        public bool Aktivan { get; set; }
        public int SpolId { get; set; }
        public Spol Spol { get; set; }
        public List<PolozeniPredmet> PolozeniPredmeti { get; set; }
        public Student()
        {
            PolozeniPredmeti = new List<PolozeniPredmet>();
        }
        public override string ToString()
        {
            return $"({BrojIndeksa}) {Ime} {Prezime}";
        }
    }
    public class _Student
    {
        int _indeks;
        string _ime;
        string _prezime;

        public int GetIndeks() { return _indeks; }
        public void SetIndeks(int indeks) { _indeks = indeks; }
        public string Prezime { get; set; }
        public int GodinaStudija { get; set; }
        public int? MentorId { get; set; }
        public _Student() { }
        public _Student(int indeks, string ime, string prezime)
        {
            _indeks = indeks;
            _ime = ime;
            Prezime = prezime;
        }
        public override string ToString()
        {
            return $"({_indeks}) -> {_ime} {Prezime} godina {GodinaStudija}";
        }
        public void Deconstruct(out string prezime, out int godinaStudija)
        {
            prezime = Prezime;
            godinaStudija = GodinaStudija;
        }

        int[] Ocjene = new int[30];

        public int this[int lokacija]
        {
            get { return Ocjene[lokacija]; }
            set { Ocjene[lokacija] = value; }
        }

    }
    public struct DLStudent
    {
        public string Prezime { get; set; }
        public int GodinaStudija { get; set; }

        public override string ToString()
        {
            return $"Prezime: {Prezime} Godina studija: {GodinaStudija}";
        }
    }
    public class Konekcija
    {
        public List<_Student> GetStudentByGodinaStudija(int godinaStudija)
        {
            return new List<_Student>()
            {
                new _Student() {Prezime= "Prezime1", GodinaStudija= godinaStudija},
                new _Student() {Prezime= "Prezime2", GodinaStudija= godinaStudija},
                new _Student() {Prezime= "Prezime3", GodinaStudija= godinaStudija},
            };
        }

        public _Student GetStudentByIndeks(string indeks)
        {
            return new _Student()
            {
                Prezime = $"Student {indeks}",
                GodinaStudija = 1,
                MentorId = null,
            };
        }
    }
    public class PolozeniPredmet
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public Predmet Predmet { get; set; }
        public int Ocjene { get; set; }
    }
    public class Predmet
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }

}
