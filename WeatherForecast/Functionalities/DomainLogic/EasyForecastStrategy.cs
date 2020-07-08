﻿using System;
using System.Collections.Generic;
using Functionalities.Contracts;

namespace Functionalities.DomainLogic
{
    public class EasyForecastStrategy : IForecastStrategy
    {
        List<string> IForecastStrategy.GetForecast(int zipcode, ITemperatureStrategy temperatureStrategy, DateTime date)
        {
            List<string> result = new List<string>();
            WeatherForecast weatherForecast = new WeatherForecast();
            try
            {
                result.Add(weatherForecast.GetWeatherForecastForZip(zipcode, date));
            }
            catch
            {
                //ToDo Logging
                throw;
            }
            return result;
        }
    }
}