using Karlstad.WebApp.Interfaces;
using System.Collections.Generic;

namespace Karlstad.WebApp.Models
{
    public class WeatherForecast : IWeatherForecast
    {
        public IEnumerable<Daily> Daily { get; set; }
    }
}
