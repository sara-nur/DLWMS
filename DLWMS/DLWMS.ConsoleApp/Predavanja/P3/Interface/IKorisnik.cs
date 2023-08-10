namespace DLWMS.ConsoleApp.Predavanja.P3.Interface;

public interface IKorisnik
{
    string KorisnickoIme { get; set; }
    string Lozinka { get; set; }
    bool Prijava();
}