using System;
using System.Collections.Generic;
using Functionalities.Contracts;

namespace Functionalities.DomainLogic
{
    public class HourlyForecastStrategy : IForecastStrategy
    {
        private WeatherForecast _weatherForecast;

        public HourlyForecastStrategy(WeatherForecast weatherForecast)
        {
            _weatherForecast = weatherForecast;
        }

        public List<string> GetForecast(int zipcode, ITemperatureStrategy temperatureStrategy, DateTime date)
        {
            return _weatherForecast.GetHourlyWeatherForecast(zipcode, temperatureStrategy, date);
        }
    }
}