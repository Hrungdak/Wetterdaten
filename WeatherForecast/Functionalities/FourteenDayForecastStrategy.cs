using System;
using System.Collections.Generic;
using System.Globalization;

namespace Functionalities
{
    public class FourteenDayForecastStrategy : IForecastStrategy
    {
        List<string> IForecastStrategy.GetForecastStrategy(int zipcode, ITemperatureStrategy temperatureStrategy, DateTime date)
        {
            List<string> result = new List<string>();
            WeatherForecast weatherForecast = new WeatherForecast();
            for (int fourteenDayCounter = 0; fourteenDayCounter < 14; fourteenDayCounter++)
            {
                result.Add(weatherForecast.GetWeatherForecastForZip(zipcode, date.AddDays(fourteenDayCounter)));
            }
            return result;
        }
    }
}