using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeatherStation.Tests
{
    [TestClass]
    public class UnixTimestampConverterTests
    {
        [TestMethod]
        public void GetCurrentDatetime_ForUnixTimeInt_DateTimeToString_u()
        {
            // arrange
            int unixTimestamp = 1640995200;
            // act
            DateTime dateTime = WeatherStation.UnixTimestampConverter.GetCurrentDatetime(unixTimestamp);
            string date = dateTime.ToString("u");
            // assert
            Assert.AreEqual("2022-01-01 01:00:00Z", date);
        }


        [TestMethod]
          public void GetNDaysAgo_For5days_DateTimeToString()
          {
              //arrange
              DateTime dateTime = new DateTime(2022, 3, 1, 0, 0, 0);

              //act
              int nDaysAgo = WeatherStation.UnixTimestampConverter.GetNDaysAgo(5);

              //asserts

              Assert.IsTrue(nDaysAgo>1645660800);
              Assert.IsTrue(nDaysAgo<1646179199);
        }

    }
}
