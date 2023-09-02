namespace DLWMS.Data
{
    public class Uloga
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public ICollection<Student> Student { get; set; }
        public Uloga()
        {
            Student = new HashSet<Student>();
        }
    }

}
