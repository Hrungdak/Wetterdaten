using FluentAssertions;
using Functionalities;
using NUnit.Framework;
using System;

namespace FunctionalitiesTest
{
    [TestFixture]
    public class WeatherForecastTest
    {
        [Test]
        public void GetWeatherForecastForZip_ZipcodeAndTypeOfForecastIsEasy_ReturnsForecastForToday()
        {
            //arr
            var sut = new WeatherForecast();

            //act
            var result = sut.GetWeatherForecastForZip(12345, ForecastTypeEnum.easy);

            //assert
            result.Count.Should().Be(1);
        }

        [Test]
        public void GetWeatherForecastForZip_ZipcodeAndTypeOfForecastIsHourly_ReturnsHourlyForecastForToday()
        {
            //arr
            var sut = new WeatherForecast();

            //act
            var result = sut.GetWeatherForecastForZip(12345, ForecastTypeEnum.hourly);

            //assert
            result.Count.Should().Be(24);
        }

        [Test]
        public void GetWeatherForecastForZip_ZipcodeAndTypeOfForecastIsThreeDays_ReturnsForecastMorningAfternoonNightForThreeDays()
        {
            //arr
            var sut = new WeatherForecast();

            //act
            var result = sut.GetWeatherForecastForZip(12345, ForecastTypeEnum.threeDays);

            //assert
            result.Count.Should().Be(9);
        }

        [Test]
        public void GetWeatherForecastForZip_ZipcodeAndTypeOfForecastIsFourteenDays_ReturnsForecastForFourteenDays()
        {
            //arr
            var sut = new WeatherForecast();

            //act
            var result = sut.GetWeatherForecastForZip(12345, ForecastTypeEnum.fourteenDays);

            //assert
            result.Count.Should().Be(14);
        }
    }
}