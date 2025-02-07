using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

public class WebServer
{
    public static void StartServer()
    {
        var builder = WebApplication.CreateBuilder();
        var app = builder.Build();

        app.MapGet("/data", () =>
        {
            var sensorData = Sensors.ReadSensor();
            Display.ShowData(sensorData.Temperature, sensorData.Humidity);
            return Results.Json(new { Temperature = sensorData.Temperature, Humidity = sensorData.Humidity });
        });

        app.Run("http://0.0.0.0:5000");
    }
}
