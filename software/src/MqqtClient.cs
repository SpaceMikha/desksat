using System;
using System.Text;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;

public class MqttClient
{
    private static IMqttClient client;
    private static string brokerAddress = "broker.hivemq.com";
    private static string topic = "desksatellite/sensors";

    public static async void Connect()
    {
        var factory = new MqttFactory();
        client = factory.CreateMqttClient();

        var options = new MqttClientOptionsBuilder()
            .WithTcpServer(brokerAddress)
            .Build();

        await client.ConnectAsync(options);
        Console.WriteLine("Connected to MQTT broker.");
    }

    public static async void PublishData(int temperature, int humidity)
    {
        if (client == null || !client.IsConnected) return;

        var message = new MqttApplicationMessageBuilder()
            .WithTopic(topic)
            .WithPayload($"{{\"temperature\": {temperature}, \"humidity\": {humidity}}}")
            .WithRetainFlag()
            .Build();

        await client.PublishAsync(message);
        Console.WriteLine("Data published to MQTT.");
    }
}
