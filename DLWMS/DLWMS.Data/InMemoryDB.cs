namespace DLWMS.Data
{
    public class InMemoryDB
    {
        public static List<Korisnik> Korisnici = GenerisiKorisnike();
        public static List<Student> Studenti = GenerisiStudente();
        public static List<GodinaStudija> GodineStudija = GenerisiGodineStudija();
        public static List<Spol> Spolovi = GenerisanjeSpolova();
        public static List<Predmet> Predmeti = GenerisanjePredmeta();
        private static List<Predmet> GenerisanjePredmeta()
        {
            return new List<Predmet>()
             {
                new Predmet() {Id=1, Naziv="Matematika"},
                new Predmet() {Id=2, Naziv="Programiranje 1"},
                new Predmet() {Id=3, Naziv="Marketing"},
                new Predmet() {Id=4, Naziv="Operativni Sistemi"}
             };
        }
        private static List<Spol> GenerisanjeSpolova()
        {
            return new List<Spol>()
          {
              new Spol() {Id=1, Naziv="*****"},
              new Spol() {Id=2, Naziv="Ženski"},
              new Spol() {Id=3, Naziv="Muški"}
          };
        }
        private static List<GodinaStudija> GenerisiGodineStudija()
        {
            return new List<GodinaStudija>()
        {
            new GodinaStudija()
            {
                Id = 1,
                Aktivan = true,
                Oznaka = "1 - GODINA",
                Opis = "Prva godina studija"
            },
            new GodinaStudija()
            {
                Id = 2,
                Aktivan = true,
                Oznaka = "2 - GODINA",
                Opis = "Druga godina studija"
            },
            new GodinaStudija()
            {
                Id = 3,
                Aktivan = true,
                Oznaka = "3 - GODINA",
                Opis = "Treca godina studija"
            },
            new GodinaStudija()
            {
                Id = 4,
                Aktivan = true,
                Oznaka = "4 - GODINA",
                Opis = "Cetvrta godina studija"
            }
        };
        }
        private static List<Student> GenerisiStudente()
        {
            return new List<Student>()
        {
            new Student()
            {
                Id = 1,
                Aktivan = true,
                Email = "sara.nur@edu.fit.ba",
                Ime = "Sara",
                Prezime = "Nur",
                BrojIndeksa = "IB20000",
                Lozinka = "Sara",
                DatumRodjenja = new DateTime(2000,4,16),
                GodinaStudija = 1,
                Slika = null
            },
            new Student()
            {
                Id = 2,
                Aktivan = true,
                Email = "jasmin.nezic@edu.fit.ba",
                Ime = "Jasmin",
                Prezime = "Nezic",
                BrojIndeksa = "IB20001",
                Lozinka = "Jasmin",
                DatumRodjenja = new DateTime(2000,4,16),
                GodinaStudija = 1,
                Slika = null
            }
        };
        }
        private static List<Korisnik> GenerisiKorisnike()
        {
            return new List<Korisnik>()
        {
            new Korisnik()
            {
                Id = 1,
                Aktivan = true,
                Email = "admin@edu.fit.ba",
                Ime = "Administrator",
                Prezime = "FIT",
                KorisnickoIme = "admin",
                Lozinka = "admin",
            }
        };
        }
    }
}

