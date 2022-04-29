using Karlstad.WebApp.Interfaces;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Karlstad.WebApp.Models
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        private readonly HttpClient _client;

        private readonly string path = Environment.GetEnvironmentVariable("params");

        public WeatherForecastRepository(IHttpClientFactory client)
        {
            _client = client.CreateClient("WeatherForecastRepository");
        }
        public async Task<IWeatherForecast> GetKarlstadWeatherForecast()
        {
            IWeatherForecast weatherForecast = null;

            HttpResponseMessage response = await _client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                weatherForecast = await response.Content.ReadFromJsonAsync<WeatherForecast>();
            }

            return weatherForecast;
        }
    }
}
