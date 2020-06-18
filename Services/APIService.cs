using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

internal class APIService
{
    private string _apiKey;
    static HttpClient client = new HttpClient();

    internal APIService(string apiKey)
    {
        this._apiKey = apiKey;
    }

    internal async Task<WeatherResponse> GetWeatherByCityName(string city)
    {
        WeatherResponse result = null;
        string apiQuery = $"api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}";
        
        HttpResponseMessage response = await client.GetAsync(apiQuery);
        if (response.IsSuccessStatusCode)
        {
            result = await response.Content.ReadAsAsync<WeatherResponse>();
        }

        return result;
    }
}