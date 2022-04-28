using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Karlstad.WebApp.Models
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        private readonly HttpClient _client;
        private readonly string path = "https://api.openweathermap.org/data/2.5/onecall?lat=59.4022&lon=13.5115&exclude=hourly,minutely,current&appid=44d8fe9c81127d78c9852535b3e34e7e&lang=se&units=metric";

        public WeatherForecastRepository(IHttpClientFactory client)
        {
            _client = client.CreateClient();
        }
        public async Task<WeatherForecast> GetKarlstadWeatherForecast()
        {
            WeatherForecast weatherForecast = null;

            HttpResponseMessage response = await _client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                weatherForecast = await response.Content.ReadFromJsonAsync<WeatherForecast>();
            }

            return weatherForecast;
        }
    }
}
