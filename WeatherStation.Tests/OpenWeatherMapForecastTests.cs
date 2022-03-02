using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.Tests
{
    [TestClass]
    public class OpenWeatherMapForecastTests
    {

        [TestMethod]
        public async Task HTTPCode_TryGenerateWeatherObject_CheckIsHttpCode200()
        {
            // arrange
            OpenWeatherMapForecast openWeatherMapForecast = new OpenWeatherMapForecast();
            // act
            await openWeatherMapForecast.GenerateWeatherObject();

            // assert
            Assert.AreEqual(openWeatherMapForecast.HttpStatusCode, 200);
        }

        [TestMethod]
        public async Task GetDailyWeather_CountResultObjects()
        {
            // arrange
            OpenWeatherMapForecast openWeatherMapForecast = new OpenWeatherMapForecast();
            // act
            await openWeatherMapForecast.GenerateWeatherObject();

            List<OneDayWeather> dailyList = openWeatherMapForecast.GetDailyWeather();

            // assert
            Assert.AreEqual(dailyList.Count, 8);
        }

        [TestMethod]
        public async Task GetHourlyWeather_CountResultObjects()
        {
            // arrange
            OpenWeatherMapForecast openWeatherMapForecast = new OpenWeatherMapForecast();
            // act
            await openWeatherMapForecast.GenerateWeatherObject();

            List<OneDayWeather> hourlyList = openWeatherMapForecast.GetHourlyWeather();

            // assert
            Assert.AreEqual(hourlyList.Count, 48);
        }
        
    }
}
