using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities
{
    public class EasyForecastStrategy : IForecastStrategy
    {
        List<string> IForecastStrategy.GetForecastStrategy(int zipcode, ITemperatureStrategy temperatureStrategy, DateTime date)
        {
            List<string> result = new List<string>();
            WeatherForecast weatherForecast = new WeatherForecast();
            result.Add(weatherForecast.GetWeatherForecastForZip(zipcode, date));
            return result;
        }
    }
}