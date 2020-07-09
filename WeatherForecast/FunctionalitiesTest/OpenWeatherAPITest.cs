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
            OpenWeatherAPI openWeatherAPI = new OpenWeatherAPI("a1fcc507923163ff1bae113a80d8f82a");
            var sut = Task.Run(() => openWeatherAPI.GetCurrentWeather(HttpClientFactory.CreateClient(), 80339));

            sut.Wait();

            var json = sut.Result;
        }
    }
}