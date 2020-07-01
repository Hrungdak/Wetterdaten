using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities
{
    public class ThreeDayForecastStrategy : IForecastStrategy
    {
        List<string> IForecastStrategy.GetForecastStrategy(int zipcode, ITemperatureStrategy temperatureStrategy, DateTime date)
        {
            List<string> result = new List<string>();
            WeatherForecast weatherForecast = new WeatherForecast();
            //ToDo. Display Morning/Afternoon/Evening and maybe new method for threeDayForecast instead GetWeatherForecastForZip
            result.Add(weatherForecast.GetWeatherForecastForZip(zipcode, date));
            result.Add(weatherForecast.GetWeatherForecastForZip(zipcode, date.AddDays(1)));
            result.Add(weatherForecast.GetWeatherForecastForZip(zipcode, date.AddDays(2)));
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