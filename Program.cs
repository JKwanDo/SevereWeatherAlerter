using System;
using System.Text.Json;
using System.Net.HTTP;
using System.Threading.Tasks;

public class SevereWeatherAlerter
{
    static async Task Main()
    {
        string url = "https://api.weather.gov";

        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.add("");
        }
    }
}