using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class CloudUploader
{
    private static readonly HttpClient httpClient = new HttpClient();
    private static string cloudApiUrl = "https://your-cloud-api.com/data";

    public static async Task UploadData(int temperature, int humidity)
    {
        string jsonData = $"{{\"temperature\": {temperature}, \"humidity\": {humidity}}}";
        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await httpClient.PostAsync(cloudApiUrl, content);
        Console.WriteLine("Cloud Upload Response: " + response.StatusCode);
    }
}
