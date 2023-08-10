namespace DLWMS.ConsoleApp.Predavanja.P3.Logger;

public class WebServisLogger : ILogger
{
    private const string Putanja = @"uri:log.fit.ba;token: 321321-sdf1312sdf0";

    public void Log(object message)
    {
        Console.WriteLine($"WebServisLog -> {Putanja}\nData-> {DataExtractor.GetData(message)}");
    }
}