namespace DLWMS.Data.Helpers
{
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

}
