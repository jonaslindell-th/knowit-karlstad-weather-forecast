using System.Threading.Tasks;

namespace Karlstad.WebApp.Models
{
    public interface IWeatherForecastRepository
    {
        Task<WeatherForecast> GetKarlstadWeatherForecast();
    }
}
