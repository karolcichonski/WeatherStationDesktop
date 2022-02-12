using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStationDesktop;

namespace WeatherStationDesctop
{
    class OpenWeatherMapForecast: OpenWeatherMap
    {
        public OpenWeatherMapForecast()
        {
            DailyWeather = new List<OneDayWeather>();
        }

        OneCallWeather OneCallWeather;
        List<OneDayWeather> DailyWeather;
        string httpRequest = $"https://api.openweathermap.org/data/2.5/onecall?lat=50.2976&lon=18.6766&units=metric&appid={DBConnection.GetOpenWetherMapAPIKey()}";

        async override public Task GenerateWeatherObject()
        {

                await GettWeatherData(httpRequest);
            if (httpStatusCode == 200 & json != null)
            {
                OneCallWeather = JsonConvert.DeserializeObject<OneCallWeather>(json);
                foreach (OneCallWeather.OneCallWeatherDaily weatherDaily in OneCallWeather.daily)
                {
                    OneDayWeather oneDayWeather = new OneDayWeather(weatherDaily, OneCallWeather.lon, OneCallWeather.lat, OneCallWeather.timezone);
                    DailyWeather.Add(oneDayWeather);
                }
            }
        }

        public List<OneDayWeather> GetDailyWeather()
        {
            return DailyWeather;
        }
    }
}
