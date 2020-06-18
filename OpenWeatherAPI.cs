using System;
using System.Threading.Tasks;

namespace OpenWeatherAPI
{
    public sealed class OpenWeatherAPI
    {
        private APIService APIService;
        public OpenWeatherAPI()
        {            
            this.APIService = new APIService("");
        }
        public OpenWeatherAPI(string apiID)
        {
            this.APIService = new APIService(apiID);
        }

        public async Task<WeatherResponse> GetWeatherByCityName(string city)
        {
            return await this.APIService.GetWeatherByCityName(city);
        }
    }
}
