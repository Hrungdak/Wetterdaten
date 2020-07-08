using System;
using System.Collections.Generic;
using Functionalities.Contracts;

namespace Functionalities.DomainLogic
{
    public class ThreeDayForecastStrategy : IForecastStrategy
    {
        List<string> IForecastStrategy.GetForecast(int zipcode, ITemperatureStrategy temperatureStrategy, DateTime date)
        {
            List<string> result = new List<string>();
            WeatherForecast weatherForecast = new WeatherForecast();
            //ToDo. Display Morning/Afternoon/Evening and maybe new method for threeDayForecast instead GetWeatherForecastForZip
            try
            {
                result.Add(weatherForecast.GetWeatherForecastForZip(zipcode, date));
                result.Add(weatherForecast.GetWeatherForecastForZip(zipcode, date.AddDays(1)));
                result.Add(weatherForecast.GetWeatherForecastForZip(zipcode, date.AddDays(2)));
            }
            catch
            {
            }
            return result;
        }

        //ToDo Do the Calculation in THreeDayFOrecastStrategy
        //public string GetForecastInMorning(int zipcode, DateTime date)
        //{
        //    TimeSpan twelveAM = new TimeSpan(0, 0, 0);
        //    DateTime dateAtTwelveAM = date.Date + twelveAM;
        //    int averageTemperature
        //}
    }
}