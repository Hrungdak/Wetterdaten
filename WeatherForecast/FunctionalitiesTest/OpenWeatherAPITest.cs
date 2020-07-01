using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Functionalities;
using NUnit.Framework;

namespace FunctionalitiesTest
{
    [TestFixture]
    internal class OpenWeatherAPITest
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