using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Functionalities;
using NUnit.Framework;

namespace FunctionalitiesTest
{
    [TestFixture]
    public class TemperatureStrategyFactoryTest
    {
        [Test]
        public void GetTemperatureStrategy_CelsiusTemperatureType_ReturnsCelsiusStrategy()
        {
            //arr
            var sut = TemperatureTypeEnum.Celsius;
            //act
            var result = TemperatureStrategyFactory.GetTemperatureStrategy(sut);
            //assert
            result.Should().BeOfType(typeof(CelsiusStrategy));
        }

        [Test]
        public void GetTemperatureStrategy_FahrenheitTemperatureType_ReturnsFahrenheitStrategy()
        {
            //arr
            var sut = TemperatureTypeEnum.Fahrenheit;
            //act
            var result = TemperatureStrategyFactory.GetTemperatureStrategy(sut);
            //assert
            result.Should().BeOfType(typeof(FahrenheitStrategy));
        }

        [Test]
        public void GetTemperatureStrategy_KelvinTemperatureType_ReturnsKelvinStrategy()
        {
            //arr
            var sut = TemperatureTypeEnum.Kelvin;
            //act
            var result = TemperatureStrategyFactory.GetTemperatureStrategy(sut);
            //assert
            result.Should().BeOfType(typeof(KelvinStrategy));
        }
    }
}