using Karlstad.WebApp.Models;
using System.Threading.Tasks;

namespace Karlstad.WebApp.Interfaces
{
    public interface IWeatherForecastRepository
    {
        Task<IWeatherForecast> GetKarlstadWeatherForecast();
    }
}
