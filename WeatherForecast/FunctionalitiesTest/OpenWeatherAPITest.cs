using System.Threading.Tasks;
using Functionalities;
using Functionalities.Adapter;
using NUnit.Framework;

namespace FunctionalitiesTest
{
    [TestFixture]
    public class OpenWeatherAPITest
    {
        [Test]
        public void Blub()
        {
            var sut = Task.Run(() => OpenWeatherAPI.GetCurrentWeather(HttpClientFactory.CreateClient(), 80339));

            sut.Wait();

            var json = sut.Result;
        }
    }
}