using System;
using System.IO;

public class DataLogger
{
    private static string logFile = "sensor_data.log";

    public static void LogData(int temperature, int humidity)
    {
        string logEntry = $"{DateTime.Now}: Temp={temperature}°C, Humidity={humidity}%";
        File.AppendAllText(logFile, logEntry + Environment.NewLine);
        Console.WriteLine("Logged: " + logEntry);
    }
}
d