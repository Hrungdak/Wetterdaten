using System;
using System.Collections.Generic;
using Functionalities.Contracts;

namespace Functionalities.DomainLogic
{
    public class FourteenDayForecastStrategy : IForecastStrategy
    {
        private WeatherForecast _weatherForecast;

        public FourteenDayForecastStrategy(WeatherForecast weatherForecast)
        {
            _weatherForecast = weatherForecast;
        }

        List<string> IForecastStrategy.GetForecast(int zipcode, ITemperatureStrategy temperatureStrategy, DateTime date)
        {
            List<string> result = new List<string>();
            for (int fourteenDayCounter = 0; fourteenDayCounter < 14; fourteenDayCounter++)
            {
                result = _weatherForecast.GetFourteenDayWeatherForecast(zipcode, temperatureStrategy, date.AddDays(fourteenDayCounter));
            }
            return result;
        }
    }
}