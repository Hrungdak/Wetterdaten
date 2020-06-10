﻿using FluentAssertions;
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
            var result = sut.GetWeatherForecastForZip(12345, ForecastTypeEnum.easy, TemperatureTypeEnum.Celsius);

            //assert
            result.Count.Should().Be(1);
        }

        [Test]
        public void GetWeatherForecastForZip_ZipcodeAndTypeOfForecastIsHourly_ReturnsHourlyForecastForToday()
        {
            //arr
            var sut = new WeatherForecast();

            //act
            var result = sut.GetWeatherForecastForZip(12345, ForecastTypeEnum.hourly, TemperatureTypeEnum.Celsius);

            //assert
            result.Count.Should().Be(24);
        }

        [Test]
        public void GetWeatherForecastForZip_ZipcodeAndTypeOfForecastIsThreeDays_ReturnsForecastMorningAfternoonNightForThreeDays()
        {
            //arr
            var sut = new WeatherForecast();

            //act
            var result = sut.GetWeatherForecastForZip(12345, ForecastTypeEnum.threeDays, TemperatureTypeEnum.Celsius);

            //assert
            result.Count.Should().Be(9);
        }

        [Test]
        public void GetWeatherForecastForZip_ZipcodeAndTypeOfForecastIsFourteenDays_ReturnsForecastForFourteenDays()
        {
            //arr
            var sut = new WeatherForecast();

            //act
            var result = sut.GetWeatherForecastForZip(12345, ForecastTypeEnum.fourteenDays, TemperatureTypeEnum.Celsius);

            //assert
            result.Count.Should().Be(14);
        }
    }
}