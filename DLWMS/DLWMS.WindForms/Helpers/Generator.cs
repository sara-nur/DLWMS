namespace DLWMS.WindForms.Helpers;

public class Generator
{
    public static string GenerisiLozinku(int brojZnakova = 10)
    {
        var generisanaLozinka = "";
        var karakteri = "qwertyuiopasdfghjkl;'zxcvbnm,-1234567890-=QWERTYUIOPASDFGHJKLČĆŽĐŠŠYXCVBNM";
        var rand = new Random();
        for (int i = 0; i < 10; i++)
        {
            var lokacija = rand.Next(0, karakteri.Length);
            generisanaLozinka += karakteri[lokacija];
        }

        return generisanaLozinka;
    }
}