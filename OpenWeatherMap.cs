using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using WeatherStationDesktop;
using Newtonsoft.Json;

namespace WeatherStationDesctop
{
    public class OpenWeatherMap
    {
        public OpenWeatherMap()
        {
            DailyWeather = new List<OneDayWeather>();
        }

        List<OneDayWeather> DailyWeather;
        OneDayWeather currentWeather;
        CurrentWeather OWMcurrentWeather;
        string json;

        string httpRequest = $"https://api.openweathermap.org/data/2.5/weather?lat=50.2976&lon=18.6766&units=metric&appid={DBConnection.GetOpenWetherMapAPIKey()}";
        
        async public Task GenerateWeatherObject()
        {
            await GettWeatherData(httpRequest);
            OWMcurrentWeather = JsonConvert.DeserializeObject<CurrentWeather>(json);
            OneDayWeather oneDayWeather = new OneDayWeather(OWMcurrentWeather);
            DailyWeather.Add(oneDayWeather);
            currentWeather = oneDayWeather;
        }

        public List<OneDayWeather> GetDailyWeather()
        {
            return DailyWeather;
        }

        public OneDayWeather GetCurrentWeather()
        {
            return currentWeather;
        }

        private async Task  GettWeatherData(string httpRequest)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var result= await httpClient.GetAsync(httpRequest);
                json = await result.Content.ReadAsStringAsync();
            }
        }
        
    }

    public class CurrentWeather
    {
        public class Coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }
        public Coord coord { get; set; }
        public Weather[] weather { get; set; }
        public string @base { get; set; }
        public class Main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
            public int pressure { get; set; }
            public double humidity { get; set; }
        }
        public Main main { get; set; }
        public int visibility { get; set; }
        public class Wind
        {
            public double speed { get; set; }
            public double deg { get; set; }
            public double gust { get; set; }
        }

        public Wind wind { get; set; }
        public class Clouds
        {
            public string all { get; set; }
        }

        public Clouds clouds { get; set; }
        public class SystemOW
        {
            public int type { get; set; }
            public int id { get; set; }
            public string country { get; set; }
            public int sunrise { get; set; }
            public int sunset { get; set; }
        }
        public SystemOW sys { get; set; }
        public int dt { get; set; }
        public string timozene { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }

    public class OneCallWeather
    {
        public double lat { get; set; }
        public double lon { get; set; }
        public string timezone { get; set; }
        public int timezone_offset { get; set; }
        public class OneCallWeatherCurrent
        {

            public int dt { get; set; }
            public int sunrise { get; set; }
            public int sunset { get; set; }
            public double temp { get; set; }
            public double feels_like { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
            public double dew_point { get; set; }
            public double wind_speed { get; set; }
            public int wind_deg { get; set; }
            public double wind_gust { get; set; }
            public Weather[] weather { get; set; }
            public int clouds { get; set; }
            public int visibility { get; set; }
            public double uvi { get; set; }
        }
        public OneCallWeatherCurrent current { get; set; }
        public class OneCallWeatherHourly
        {
            public int dt { get; set; }
            public double temp { get; set; }
            public double feels_like { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
            public double dew_point { get; set; }
            public double wind_speed { get; set; }
            public int wind_deg { get; set; }
            public double wind_gust { get; set; }
            public Weather[] weather { get; set; }
            public int clouds { get; set; }
            public int visibility { get; set; }
            public double pop { get; set; }
            public double uvi { get; set; }

        }
        public OneCallWeatherHourly[] hourly { get; set; }
        public class OneCallWeatherDaily
        {
            public int dt { get; set; }
            public int sunrise { get; set; }
            public int sunset { get; set; }
            public int moonrise { get; set; }
            public int moonset { get; set; }
            public double moon_phase { get; set; }
            public class Temp
            {
                public double day { get; set; }
                public double min { get; set; }
                public double max { get; set; }
                public double night { get; set; }
                public double eve { get; set; }
                public double morn { get; set; }

            }
            public Temp temp { get; set; }
            public class FeelsLike
            {
                public double day { get; set; }
                public double night { get; set; }
                public double eve { get; set; }
                public double morn { get; set; }
            }
            public FeelsLike feels_like { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
            public double dew_point { get; set; }
            public double wind_speed { get; set; }
            public int wind_deg { get; set; }
            public double wind_gust { get; set; }
            public Weather[] weather { get; set; }
            public int clouds { get; set; }
            public double pop { get; set; }
            public double rain { get; set; }
            public double snow { get; set; }
            public double uvi { get; set; }

        }
        public OneCallWeatherDaily[] daily { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

}
