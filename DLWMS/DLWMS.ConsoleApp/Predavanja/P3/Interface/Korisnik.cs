namespace DLWMS.ConsoleApp.Predavanja.P3.Interface;

public class Korisnik : IKorisnik, IDisposable
{
    public string KorisnickoIme { get; set; }
    public string Lozinka { get; set; }

    public bool Prijava()
    {
        Console.WriteLine("KORISNIK se prijavljuje... ");
        return true;
    }

    public void Dispose()
    {
        // TODO release managed resources here
    }
}