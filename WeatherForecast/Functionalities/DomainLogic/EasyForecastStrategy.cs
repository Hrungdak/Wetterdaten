using System;
using System.Collections.Generic;
using Functionalities.Contracts;

namespace Functionalities.DomainLogic
{
    public class EasyForecastStrategy : IForecastStrategy
    {
        private WeatherForecast _weatherForecast;

        public EasyForecastStrategy(WeatherForecast weatherForecast)
        {
            _weatherForecast = weatherForecast;
        }

        List<string> IForecastStrategy.GetForecast(int zipcode, ITemperatureStrategy temperatureStrategy, DateTime date)
        {
            List<string> result = new List<string>();
            try
            {
                result.Add(_weatherForecast.GetWeatherForecastForZip(zipcode, temperatureStrategy, date));
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