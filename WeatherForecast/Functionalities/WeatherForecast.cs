using System;
using System.Collections.Generic;
using System.Globalization;

namespace Functionalities
{
    public class WeatherForecast
    {
        public string GetRandomWeatherForecastForZip(int zipcode)
        {
            Random random = new Random();
            int randomTemperature = random.Next(11, 30);
            string randomCloudiness = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));

            return "In " + zipcode + " hat es heute " + randomTemperature + "°C und es ist " + randomCloudiness;
        }

        public List<string> GetWeatherForecastForZipRefactored(int zipcode, ForecastStrategy fcStrategy, TemperatureStrategy tempStrategy)
        {
            return fcStrategy.GetForecastForStrategy(zipcode, tempStrategy);
        }

        //public List<string> GetWeatherForecastForZip(int zipcode, ForecastTypeEnum type, TemperatureTypeEnum temperatureType)
        //{
        //    //ToDo Get rid of all switch/cases.
        //    ITemperatureStrategy strategy = null;
        //    switch (temperatureType)
        //    {
        //        case TemperatureTypeEnum.Kelvin:
        //            {
        //                strategy = new KelvinStrategy();
        //                break;
        //            }
        //        case TemperatureTypeEnum.Fahrenheit:
        //            {
        //                strategy = new FahrenheitStrategy();
        //                break;
        //            }
        //        default:
        //            {
        //                strategy = new CelsiusStrategy();
        //                break;
        //            }
        //    }

        //    switch (type)
        //    {
        //        case ForecastTypeEnum.easy:
        //            {
        //                return GetEasyForecast(zipcode, strategy);
        //            }

        //        case ForecastTypeEnum.hourly:
        //            {
        //                return GetHourlyForecast(zipcode, strategy);
        //            }

        //        case ForecastTypeEnum.threeDays:
        //            {
        //                return GetThreeDayForecast(zipcode, strategy);
        //            }

        //        case ForecastTypeEnum.fourteenDays:
        //            {
        //                return GetFourteenDayForecast(zipcode, strategy);
        //            }
        //    }

        //    return new List<string>()
        //            {
        //                "Error getting Forecast"
        //            };
        //}
    }
}