using FluentAssertions;
using Functionalities;
using NUnit.Framework;
using System;
using Functionalities.DomainLogic;
using Functionalities.Contracts;
using Functionalities.Adapter;

namespace FunctionalitiesTest
{
    [TestFixture]
    public class WeatherForecastTest
    {
        //ToDo: Unit Tests for Refactored GetWeatherForecast

        [Test]
        public void GetWeatherForecastForZip_ZipcodeAndTypeOfForecastIsEasy_ReturnsForecastForToday()
        {
            //arr
            IWeatherForecastProvider weatherForecastProvider = new OpenWeatherAPI(HttpClientFactory.CreateClient(), "a1fcc507923163ff1bae113a80d8f82a");
            WeatherForecast sut = new WeatherForecast(weatherForecastProvider);

            //act
            var result = sut.GetWeatherForecastForZip(80339, TemperatureStrategyFactory.GetTemperatureStrategy(Functionalities.Enums.TemperatureTypeEnum.Celsius), DateTime.Now);

            //assert
            //result.Count.Should().Be(1);
        }

        //[Test]
        //public void GetWeatherForecastForZip_ZipcodeAndTypeOfForecastIsHourly_ReturnsHourlyForecastForToday()
        //{
        //    //arr
        //    var sut = new WeatherForecast();

        //    //act
        //    var result = sut.GetWeatherForecastForZip(12345, ForecastTypeEnum.hourly, TemperatureTypeEnum.Celsius);

        //    //assert
        //    result.Count.Should().Be(24);
        //}

        //[Test]
        //public void GetWeatherForecastForZip_ZipcodeAndTypeOfForecastIsThreeDays_ReturnsForecastMorningAfternoonNightForThreeDays()
        //{
        //    //arr
        //    var sut = new WeatherForecast();

        //    //act
        //    var result = sut.GetWeatherForecastForZip(12345, ForecastTypeEnum.threeDays, TemperatureTypeEnum.Celsius);

        //    //assert
        //    result.Count.Should().Be(9);
        //}

        //[Test]
        //public void GetWeatherForecastForZip_ZipcodeAndTypeOfForecastIsFourteenDays_ReturnsForecastForFourteenDays()
        //{
        //    //arr
        //    var sut = new WeatherForecast();

        //    //act
        //    var result = sut.GetWeatherForecastForZip(12345, ForecastTypeEnum.fourteenDays, TemperatureTypeEnum.Celsius);

        //    //assert
        //    result.Count.Should().Be(14);
        //}
    }
}