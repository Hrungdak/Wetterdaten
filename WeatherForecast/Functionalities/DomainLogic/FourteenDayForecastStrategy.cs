﻿using System;
using System.Collections.Generic;
using Functionalities.Contracts;

namespace Functionalities.DomainLogic
{
    public class FourteenDayForecastStrategy : IForecastStrategy
    {
        List<string> IForecastStrategy.GetForecast(int zipcode, ITemperatureStrategy temperatureStrategy, DateTime date)
        {
            List<string> result = new List<string>();
            WeatherForecast weatherForecast = new WeatherForecast();
            for (int fourteenDayCounter = 0; fourteenDayCounter < 14; fourteenDayCounter++)
            {
                result.Add(weatherForecast.GetWeatherForecastForZip(zipcode, temperatureStrategy, date.AddDays(fourteenDayCounter)));
            }
            return result;
        }
    }
}