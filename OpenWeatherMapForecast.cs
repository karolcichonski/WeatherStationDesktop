using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStationDesktop;

namespace WeatherStation
{
    public class OpenWeatherMapForecast: OpenWeatherMap
    {
        public OpenWeatherMapForecast()
        {
            DailyWeather = new List<OneDayWeather>();
            HourlyWeather = new List<OneDayWeather>();
        }

        OneCallWeather OneCallWeather;
        List<OneDayWeather> DailyWeather;
        List<OneDayWeather> HourlyWeather;

        async override public Task GenerateWeatherObject()
        {
            longitude = Properties.Settings.Default.longitude;
            latitude = Properties.Settings.Default.latitude;
            string httpRequest = $"https://api.openweathermap.org/data/2.5/onecall?lat={latitude}&lon={longitude}&units=metric&appid={DBConnection.GetOpenWetherMapAPIKey()}";

            await GettWeatherData(httpRequest);
            if (HttpStatusCode == 200 & json != null)
            {
                OneCallWeather = JsonConvert.DeserializeObject<OneCallWeather>(json);
                foreach (OneCallWeather.OneCallWeatherDaily weatherDaily in OneCallWeather.daily)
                {
                    OneDayWeather oneDayWeather = new OneDayWeather(weatherDaily, OneCallWeather.lon, OneCallWeather.lat, OneCallWeather.timezone);
                    DailyWeather.Add(oneDayWeather);
                }
                foreach (OneCallWeather.OneCallWeatherHourly weatherHourly in OneCallWeather.hourly)
                {
                    OneDayWeather oneDayWeather = new OneDayWeather(weatherHourly, OneCallWeather.lon, OneCallWeather.lat, OneCallWeather.timezone);
                    HourlyWeather.Add(oneDayWeather);
                }
            }
        }

        public List<OneDayWeather> GetDailyWeather()
        {
            return DailyWeather;
        }

        public List<OneDayWeather> GetHourlyWeather()
        {
            return HourlyWeather;
        }
    }
}
