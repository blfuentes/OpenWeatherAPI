using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public static class HttpContentExtensions
{
    public static async Task<T> ReadAsAsync<T>(this HttpContent content)
    {
        return JsonSerializer.Deserialize<T>(await content.ReadAsStringAsync(), 
            (new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }));
    }
        
}