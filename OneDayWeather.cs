using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStationDesctop
{
    public class OneDayWeather
    {
        public OneDayWeather(CurrentWeather currentWeather)
        {
            Lon = currentWeather.coord.lon;
            Lat = currentWeather.coord.lat;
            Main = currentWeather.weather[0].main;
            Description = currentWeather.weather[0].description;
            Icon = currentWeather.weather[0].icon;
            Temp = currentWeather.main.temp;
            Feels_like = currentWeather.main.feels_like;
            Temp_min = currentWeather.main.temp_min;
            Temp_max = currentWeather.main.temp_max;
            Pressure = currentWeather.main.pressure;
            Humidity = currentWeather.main.humidity;
            WindSpeed = currentWeather.wind.speed * 3.6;
            WindDeg = currentWeather.wind.deg;
            WindGust = currentWeather.wind.gust * 3.6;
            CloudAll = currentWeather.clouds.all;
            Country = currentWeather.sys.country;
            Sunrise = UnixTimestampConverter.GetCurrentDatetime(currentWeather.sys.sunrise);
            Sunset = UnixTimestampConverter.GetCurrentDatetime(currentWeather.sys.sunset);
            DateTime = UnixTimestampConverter.GetCurrentDatetime(currentWeather.dt);
            Timozene = currentWeather.timozene;
            Name = currentWeather.name;
            Visibility = currentWeather.visibility;
        }

        public double Lon { get; private set; }
        public double Lat { get; private set; }
        public string Main { get; private set; }
        public string Description { get; private set; }
        public string Icon { get; private set; }
        public double Temp { get; private set; }
        public double Feels_like { get; private set; }
        public double Temp_min { get; private set; }
        public double Temp_max { get; private set; }
        public int Pressure { get; private set; }
        public double Humidity { get; private set; }
        public double WindSpeed { get; private set; }
        public double WindDeg { get; private set; }
        public double WindGust { get; private set; }
        public string CloudAll { get; private set; }
        public string Country { get; private set; }
        public DateTime Sunrise { get; private set; }
        public DateTime Sunset { get; private set; }
        public DateTime DateTime { get; private set; }
        public string Timozene { get; private set; }
        public int Visibility { get; private set; }
        public string Name { get; private set; }
    }
}
