using System;
using System.Collections.Generic;
using Functionalities.Contracts;

namespace Functionalities.DomainLogic
{
    public class ThreeDayForecastStrategy : IForecastStrategy
    {
        private WeatherForecast _weatherForecast;

        public ThreeDayForecastStrategy(WeatherForecast weatherForecast)
        {
            _weatherForecast = weatherForecast;
        }

        List<string> IForecastStrategy.GetForecast(int zipcode, ITemperatureStrategy temperatureStrategy, DateTime date)
        {
            List<string> result = new List<string>();
            try
            {
                result = _weatherForecast.GetThreeDayWeatherForecast(zipcode, temperatureStrategy, date);
            }
            catch
            {
            }
            return result;
        }
    }
}