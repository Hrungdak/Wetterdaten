using FluentAssertions;
using Functionalities;
using Functionalities.DomainLogic;
using Functionalities.Enums;
using NUnit.Framework;

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
            //act
            var result = ForecastStrategyFactory.GetForecastStrategy(sut);
            //assert
            result.Should().BeOfType(typeof(EasyForecastStrategy));
        }

        [Test]
        public void GetForecastStrategy_HourlyForecastType_ReturnsHourlyForecastStrategy()
        {
            //arr
            var sut = ForecastTypeEnum.hourly;
            //act
            var result = ForecastStrategyFactory.GetForecastStrategy(sut);
            //assert
            result.Should().BeOfType(typeof(HourlyForecastStrategy));
        }

        [Test]
        public void GetForecastStrategy_ThreeDaysForecastType_ReturnsThreeDayForecastStrategy()
        {
            //arr
            var sut = ForecastTypeEnum.threeDays;
            //act
            var result = ForecastStrategyFactory.GetForecastStrategy(sut);
            //assert
            result.Should().BeOfType(typeof(ThreeDayForecastStrategy));
        }

        [Test]
        public void GetForecastStrategy_FourteenDayForecastStrategy_ReturnsFourteenDayForecastStrategy()
        {
            //arr
            var sut = ForecastTypeEnum.fourteenDays;
            //act
            var result = ForecastStrategyFactory.GetForecastStrategy(sut);
            //assert
            result.Should().BeOfType(typeof(FourteenDayForecastStrategy));
        }
    }
}