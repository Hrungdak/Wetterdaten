using FluentAssertions;
using Functionalities.Adapter;
using Functionalities.Contracts;
using Functionalities.DomainLogic;
using Functionalities.Enums;
using NUnit.Framework;
using Functionalities;

namespace FunctionalitiesTest
{
    [TestFixture]
    public class ForecastStrategyFactoryTest
    {
        [Test]
        public void GetForecastStrategy_EasyForecastType_ReturnsEasyForecastStrategy()
        {
            //arr
            var sut = ForecastTypeEnum.easy;
            IWeatherForecastProvider weatherForecastProvider = new OpenWeatherAPI(HttpClientFactory.CreateClient(), "a1fcc507923163ff1bae113a80d8f82a");
            WeatherForecast weatherForecast = new WeatherForecast(weatherForecastProvider);
            //act
            var result = ForecastStrategyFactory.GetForecastStrategy(sut, weatherForecast);
            //assert
            result.Should().BeOfType(typeof(EasyForecastStrategy));
        }

        [Test]
        public void GetForecastStrategy_HourlyForecastType_ReturnsHourlyForecastStrategy()
        {
            //arr
            var sut = ForecastTypeEnum.hourly;
            IWeatherForecastProvider weatherForecastProvider = new OpenWeatherAPI(HttpClientFactory.CreateClient(), "a1fcc507923163ff1bae113a80d8f82a");
            WeatherForecast weatherForecast = new WeatherForecast(weatherForecastProvider);
            //act
            var result = ForecastStrategyFactory.GetForecastStrategy(sut, weatherForecast);
            //assert
            result.Should().BeOfType(typeof(HourlyForecastStrategy));
        }

        [Test]
        public void GetForecastStrategy_ThreeDaysForecastType_ReturnsThreeDayForecastStrategy()
        {
            //arr
            var sut = ForecastTypeEnum.threeDays;
            IWeatherForecastProvider weatherForecastProvider = new OpenWeatherAPI(HttpClientFactory.CreateClient(), "a1fcc507923163ff1bae113a80d8f82a");
            WeatherForecast weatherForecast = new WeatherForecast(weatherForecastProvider);
            //act
            var result = ForecastStrategyFactory.GetForecastStrategy(sut, weatherForecast);
            //assert
            result.Should().BeOfType(typeof(ThreeDayForecastStrategy));
        }

        [Test]
        public void GetForecastStrategy_FourteenDayForecastStrategy_ReturnsFourteenDayForecastStrategy()
        {
            //arr
            var sut = ForecastTypeEnum.fourteenDays;
            IWeatherForecastProvider weatherForecastProvider = new OpenWeatherAPI(HttpClientFactory.CreateClient(), "a1fcc507923163ff1bae113a80d8f82a");
            WeatherForecast weatherForecast = new WeatherForecast(weatherForecastProvider);
            //act
            var result = ForecastStrategyFactory.GetForecastStrategy(sut, weatherForecast);
            //assert
            result.Should().BeOfType(typeof(FourteenDayForecastStrategy));
        }
    }
}