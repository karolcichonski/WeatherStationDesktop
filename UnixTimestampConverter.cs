using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationDesctop
{
    class UnixTimestampConverter
    {
        public static DateTime GetCurrentDatetime(int unixTimestamp)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimestamp).ToLocalTime();
            return dateTime;
        }

        public static int GetNDaysAgo(int daysAgo)
        {
            DateTime fiveDaysAgo = DateTime.Now.AddDays(-daysAgo);
            DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = fiveDaysAgo.ToUniversalTime() - unixStart;
            return (int)diff.TotalSeconds;
        }
    }
}
