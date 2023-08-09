namespace DLWMS.ConsoleApp.Predavanja.P3;

public class Konfiguracija
{
    public const string Naziv = "DLWMS";
    public readonly string KonekcijskiString;

    public Konfiguracija(string konekcijskiString)
    {
        KonekcijskiString = konekcijskiString;
    }

}