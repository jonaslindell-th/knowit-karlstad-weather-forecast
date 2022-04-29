
using Karlstad.WebApp.Models;
using System.Collections.Generic;

namespace Karlstad.WebApp.Interfaces
{
    public interface IWeatherForecast
    {
        IEnumerable<Daily> Daily { get; set; }
    }
}
