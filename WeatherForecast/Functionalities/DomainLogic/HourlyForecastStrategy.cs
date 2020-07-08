using System;
using System.Collections.Generic;
using Functionalities.Contracts;

namespace Functionalities.DomainLogic
{
    public class HourlyForecastStrategy : IForecastStrategy
    {
        public List<string> GetForecast(int zipcode, ITemperatureStrategy temperatureStrategy, DateTime date)
        {
            WeatherForecast weatherForecast = new WeatherForecast();
            return weatherForecast.GetHourlyWeatherForecast(zipcode, date);
        }
    }
}