using System;
using System.Threading;

public class Sensors
{
    public static (int Temperature, int Humidity) ReadSensor()
    {
        Random rand = new Random();
        int temperature = rand.Next(10, 40);
        int humidity = rand.Next(20, 100);
        Console.WriteLine($"Temp: {temperature}°C, Humidity: {humidity}%");
        return (temperature, humidity);
    }

    public static void Main()
    {
        while (true)
        {
            ReadSensor();
            Thread.Sleep(2000);
        }
    }
}
