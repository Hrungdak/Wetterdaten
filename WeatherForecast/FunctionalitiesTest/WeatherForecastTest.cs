using FluentAssertions;
using Functionalities;
using Functionalities.Enums;
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
        [Test]
        public void GetWeatherForecastForZip_OpenWeatherGetCurrentWeather_ReturnsForecastForToday()
        {
            //arr
            IWeatherForecastProvider weatherForecastProvider = new OpenWeatherAPI(HttpClientFactory.CreateClient(), "a1fcc507923163ff1bae113a80d8f82a");
            WeatherForecast sut = new WeatherForecast(weatherForecastProvider);

            //act
            var result = sut.GetWeatherForecastForZip(80339, TemperatureStrategyFactory.GetTemperatureStrategy(TemperatureTypeEnum.Celsius), DateTime.Now);

            //assert
            //result.Count.Should().Be(1);
        }

        [Test]
        public void GetWeatherForecastForZip_OpenWeatherOneCallAPI_ReturnsHourlyForecastForNext48Hours()
        {
            //arr
            IWeatherForecastProvider weatherForecastProvider = new OpenWeatherAPI(HttpClientFactory.CreateClient(), "a1fcc507923163ff1bae113a80d8f82a");
            WeatherForecast sut = new WeatherForecast(weatherForecastProvider);

            //act
            var result = sut.GetHourlyWeatherForecast(80339, TemperatureStrategyFactory.GetTemperatureStrategy(TemperatureTypeEnum.Celsius), DateTime.Now);

            //assert
            result.Count.Should().Be(48);
        }

        [Test]
        public void GetWeatherForecastForZip_OpenWeatherOneCallAPI_ReturnsThreeDayForecast()
        {
            //arr
            IWeatherForecastProvider weatherForecastProvider = new OpenWeatherAPI(HttpClientFactory.CreateClient(), "a1fcc507923163ff1bae113a80d8f82a");
            WeatherForecast sut = new WeatherForecast(weatherForecastProvider);

            //act
            var result = sut.GetThreeDayWeatherForecast(80339, TemperatureStrategyFactory.GetTemperatureStrategy(TemperatureTypeEnum.Celsius), DateTime.Now);

            //assert
            result.Count.Should().Be(9);
        }

        [Test]
        public void GetWeatherForecastForZip_OpenWeatherOneCallAPI_ReturnsFourteenDayForecast()
        {
            //arr
            IWeatherForecastProvider weatherForecastProvider = new OpenWeatherAPI(HttpClientFactory.CreateClient(), "a1fcc507923163ff1bae113a80d8f82a");
            WeatherForecast sut = new WeatherForecast(weatherForecastProvider);

            //act
            var result = sut.GetFourteenDayWeatherForecast(80339, TemperatureStrategyFactory.GetTemperatureStrategy(TemperatureTypeEnum.Celsius), DateTime.Now);

            //assert
            result.Count.Should().Be(14);
        }
    }
}