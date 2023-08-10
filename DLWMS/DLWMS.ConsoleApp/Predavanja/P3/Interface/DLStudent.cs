namespace DLWMS.ConsoleApp.Predavanja.P3.Interface;

public class DLStudent : Osoba, IKorisnik, IStudent
{
    public string Indeks { get; set; }
    public DLStudent(string indeks, string ime, string prezime)
        : base(ime, prezime)
    {
        Indeks = indeks;
    }
    public override string PredstaviSe()
    {
        return $"{Indeks} - {Ime} - {Prezime}";
    }
    public override string Info()
    {
        return $"{Indeks} - {base.Info()}";
    }
    public string KorisnickoIme { get; set; }
    public string Lozinka { get; set; }
    public bool Prijava()
    {
        Console.WriteLine("DLStudent se prijavljuje... ");
        return true;
    }
    public bool PrijaviIspit()
    {
        throw new NotImplementedException();
    }
}