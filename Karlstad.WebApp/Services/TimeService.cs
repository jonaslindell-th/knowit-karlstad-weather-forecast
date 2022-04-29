using System;

namespace Karlstad.WebApp.Services
{
    public static class TimeService
    {
        public static string UnixTimeStampToString(double unixTimeStamp)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime.ToString("dddd, dd MMMM yyyy");
        }
    }
}
