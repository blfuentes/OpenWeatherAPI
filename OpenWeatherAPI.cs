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

        public async Task<WeatherResponse> GetWeatherByCityNameAsObject(string city)
        {
            return await this.APIService.GetWeatherByCityNameAsObject(city);
        }

        public async Task<string> GetWeatherByCityNameAsJSon(string city)
        {
            return await this.APIService.GetWeatherByCityNameAsJSon(city);
        }
    }
}
