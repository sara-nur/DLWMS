namespace DLWMS.ConsoleApp.Predavanja.P3.Logger;

public class DataExtractor
{
    public static string GetData(object message)
    {
        if (message == null) return string.Empty; //ukoliko je null vrati prazan string
        if (message is Exception)
            return (message as Exception).Message;   //ukoliko je exception prikazi exceotion poruku 
        return message.ToString();     //ukoliko nije nijedno, vrati poruku 
    }
}