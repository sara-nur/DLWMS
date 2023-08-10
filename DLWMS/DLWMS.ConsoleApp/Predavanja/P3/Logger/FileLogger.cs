namespace DLWMS.ConsoleApp.Predavanja.P3.Logger;

public class FileLogger : ILogger
{
    private const string Putanja = @"c:\logs\dlwms_log.txt";

    public void Log(object message)
    {
        Console.WriteLine($"FileLog -> {Putanja}\nData-> {DataExtractor.GetData(message)}");
    }
}