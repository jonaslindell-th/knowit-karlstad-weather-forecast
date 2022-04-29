using Karlstad.WebApp.Interfaces;
using Karlstad.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Karlstad.WebApp.Controllers
{
    public class WeatherForecastController : Controller
    {
        private readonly IWeatherForecastRepository _weatherForecastRepository;
        public WeatherForecastController(IWeatherForecastRepository weatherForecastRepository)
        {
            _weatherForecastRepository = weatherForecastRepository;
        }
        public async Task<IActionResult> Index()
        {
            WeatherForecast weatherForecast = await _weatherForecastRepository.GetKarlstadWeatherForecast();
            return View(weatherForecast);
        }
    }
}
