namespace DLWMS.Data.Helpers
{
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

}
