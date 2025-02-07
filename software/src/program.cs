using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting DeskSatellite...");

        Database.Initialize();
        MqttClient.Connect();

        Thread serverThread = new Thread(WebServer.StartServer);
        serverThread.Start();

        while (true)
        {
            var sensorData = Sensors.ReadSensor();
            Display.ShowData(sensorData.Temperature, sensorData.Humidity);
            DataLogger.LogData(sensorData.Temperature, sensorData.Humidity);
            Database.StoreData(sensorData.Temperature, sensorData.Humidity);
            MqttClient.PublishData(sensorData.Temperature, sensorData.Humidity);
            await CloudUploader.UploadData(sensorData.Temperature, sensorData.Humidity);

            Thread.Sleep(5000);
        }
    }
}
