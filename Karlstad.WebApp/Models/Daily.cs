using System.Collections.Generic;

namespace Karlstad.WebApp.Models
{
    public class Daily
    {
        public int Dt { get; set; }
        public double Wind_Speed { get; set; }
        public Temperature Temp { get; set; }
        public IEnumerable<Weather> Weather { get; set; }
    }
}
