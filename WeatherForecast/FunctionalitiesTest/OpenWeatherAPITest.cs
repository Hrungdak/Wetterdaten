using System.Threading.Tasks;
using FluentAssertions;
using Functionalities;
using Functionalities.Adapter;
using Functionalities.DomainModels;
using NUnit.Framework;

namespace FunctionalitiesTest
{
    [TestFixture]
    public class OpenWeatherAPITest
    {
        [Test]
        public void CurrentWeatherTest()
        {
            OpenWeatherAPI openWeatherAPI = new OpenWeatherAPI("a1fcc507923163ff1bae113a80d8f82a");
            var sut = Task.Run(() => openWeatherAPI.GetCurrentWeather(HttpClientFactory.CreateClient(), 80339));

            sut.Wait();

            var json = sut.Result;
        }

        [Test]
        public void OneCallAPITest_GetHourlyWeather_ReturnsTrue()
        {
            //OpenWeatherAPI openWeatherAPI = new OpenWeatherAPI("a1fcc507923163ff1bae113a80d8f82a");
            //var sut = Task.Run(() => openWeatherAPI.GetOpenWeatherOneCallDomainModel(HttpClientFactory.CreateClient(), 80339));

            //sut.Wait();

            //var json = sut.Result;

            OpenWeatherAPI sut = new OpenWeatherAPI("a1fcc507923163ff1bae113a80d8f82a");
            var data = Task.Run(() => sut.GetHourlyWeather(HttpClientFactory.CreateClient(), 80339));
            data.Wait();

            var result = data.Result;
            result.Should().BeOfType(typeof(HourlyValuesDomainModel));
        }

        [Test]
        public void OneCallAPITest_GetWeatherForThreeDays_ReturnsTrue()
        {
            OpenWeatherAPI sut = new OpenWeatherAPI("a1fcc507923163ff1bae113a80d8f82a");
            var data = Task.Run(() => sut.GetWeatherForThreeDays(HttpClientFactory.CreateClient(), 80339));
            data.Wait();

            var result = data.Result;
            result.Should().BeOfType(typeof(ThreeDayValuesDomainModel));
        }

        [Test]
        public void OneCallAPITest_GetWeatherForFourteenDays_ReturnsTrue()
        {
            OpenWeatherAPI sut = new OpenWeatherAPI("a1fcc507923163ff1bae113a80d8f82a");
            var data = Task.Run(() => sut.GetWeatherForFourteenDays(HttpClientFactory.CreateClient(), 80339));
            data.Wait();

            var result = data.Result;
            result.Should().BeOfType(typeof(FourteenDayValuesDomainModel));
        }
    }
}