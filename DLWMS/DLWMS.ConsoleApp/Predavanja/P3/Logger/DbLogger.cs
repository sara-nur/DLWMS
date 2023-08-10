namespace DLWMS.ConsoleApp.Predavanja.P3.Logger;

public class DbLogger : ILogger
{
    private const string Putanja = "Server = 192.168.1.10;MyDataBase = DLWMS";

    public void Log(object message)
    {
        Console.WriteLine($"DBLog -> {Putanja}\nData-> {DataExtractor.GetData(message)}");
    }
}