using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStationDesktop;

namespace WeatherStationDesctop
{
    class OpenWeatherMapHistorical : OpenWeatherMap
    {
        int daysAgo = UnixTimestampConverter.GetNDaysAgo(5);
        OneCallWeather OneCallWeather;
        List<OneDayWeather> HourlyWeather;


        async override public Task GenerateWeatherObject()
        {
            HourlyWeather = new List<OneDayWeather>();

            for (int i=5; i>0; i--)
            {
                daysAgo = UnixTimestampConverter.GetNDaysAgo(i);
                httpRequest = $"https://api.openweathermap.org/data/2.5/onecall/timemachine?lat=50.2976&lon=18.6766&dt={daysAgo}&units=metric&appid={DBConnection.GetOpenWetherMapAPIKey()}";
                await GettWeatherData(httpRequest);
                if (httpStatusCode == 200 & json != null)
                {
                    OneCallWeather = JsonConvert.DeserializeObject<OneCallWeather>(json);
                    foreach (OneCallWeather.OneCallWeatherHourly weatherHourly in OneCallWeather.hourly)
                    {
                        OneDayWeather oneDayWeather = new OneDayWeather(weatherHourly, OneCallWeather.lon, OneCallWeather.lat, OneCallWeather.timezone);
                        HourlyWeather.Add(oneDayWeather);
                    }
                }
            }
        }

        public List<OneDayWeather> GetHourlyWeather()
        {
            return HourlyWeather;
        }
    }
}
