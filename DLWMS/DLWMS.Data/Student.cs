namespace DLWMS.Data
{
    public class Student 
    {
        int _indeks;
        string _ime;
        string _prezime;

        public int GetIndeks( ) {  return _indeks; }
        public void SetIndeks(int indeks) { _indeks = indeks; }


        public string Prezime { get; set; }

        public int GodinaStudija { get; set; }

        public Student(){}
        public Student(int indeks, string ime, string prezime)
        {
            _indeks = indeks;
            _ime = ime;
            Prezime = prezime;
        }

        public override string ToString( )
        {
            return $"({_indeks}) {_ime} {Prezime} {GodinaStudija}";
        }
    }
}