using System.Collections.Generic;

namespace Karlstad.WebApp.Models
{
    public class WeatherForecast
    {
        public IEnumerable<Daily> Daily { get; set; }
    }
}
