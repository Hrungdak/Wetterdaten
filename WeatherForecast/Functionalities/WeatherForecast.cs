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

        public List<string> GetWeatherForecastForZip(int zipcode, ForecastTypeEnum type, TemperatureTypeEnum temperatureType)
        {
            ITemperatureStrategy strategy = null;
            switch (temperatureType)
            {
                case TemperatureTypeEnum.Kelvin:
                    {
                        strategy = new KelvinStrategy();
                        break;
                    }
                case TemperatureTypeEnum.Fahrenheit:
                    {
                        strategy = new FahrenheitStrategy();
                        break;
                    }
                default:
                    {
                        strategy = new CelsiusStrategy();
                        break;
                    }
            }

            switch (type)
            {
                case ForecastTypeEnum.easy:
                    {
                        return GetEasyForecast(zipcode, strategy);
                    }

                case ForecastTypeEnum.hourly:
                    {
                        return GetHourlyForecast(zipcode, strategy);
                    }

                case ForecastTypeEnum.threeDays:
                    {
                        return GetThreeDayForecast(zipcode, strategy);
                    }

                case ForecastTypeEnum.fourteenDays:
                    {
                        return GetFourteenDayForecast(zipcode, strategy);
                    }
            }

            return new List<string>()
                    {
                        "Error getting Forecast"
                    };
        }

        public List<string> GetEasyForecast(int zipcode, ITemperatureStrategy strategy)
        {
            List<string> forecast = new List<string>();
            DateTime time = DateTime.Today;
            Random random = new Random();
            TemperatureInfo info = strategy.GetTemperatureFromCelsius(random.Next(11, 30));
            string randomCloudiness = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));
            forecast.Add(time.ToString("D") + ": In " + zipcode +
                    " hat es " + info.Temperature + " " + info.Display + ", und ist " + randomCloudiness);
            return forecast;
        }

        public List<string> GetHourlyForecast(int zipcode, ITemperatureStrategy strategy)
        {
            List<string> forecast = new List<string>();
            DateTime time = DateTime.Today;
            Random random = new Random();
            for (int hourOfDay = 0; hourOfDay < 24; hourOfDay++)
            {
                string randomCloudiness = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));
                TemperatureInfo info = strategy.GetTemperatureFromCelsius(random.Next(11, 30));
                forecast.Add(time.ToString() + ": In " + zipcode +
                    " hat es " + info.Temperature + " " + info.Display + ", und ist " + randomCloudiness);
                time = time.AddHours(1.0);
            }

            return forecast;
        }

        public List<string> GetThreeDayForecast(int zipcode, ITemperatureStrategy strategy)
        {
            List<string> forecast = new List<string>();
            DateTime time = DateTime.Today;
            Random random = new Random();
            for (int dayoffset = 0; dayoffset < 3; dayoffset++)
            {
                TemperatureInfo info_vormittag = strategy.GetTemperatureFromCelsius(random.Next(11, 30));
                TemperatureInfo info_nachmittag = strategy.GetTemperatureFromCelsius(random.Next(11, 30));
                TemperatureInfo info_nacht = strategy.GetTemperatureFromCelsius(random.Next(11, 30));
                string randomCloudiness_vormittag = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));
                string randomCloudiness_nachmittag = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));
                string randomCloudiness_nacht = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));

                forecast.Add(time.ToString("d") + ": In " + zipcode +
                    " hat es vormittags " + info_vormittag.Temperature + " " + info_vormittag.Display + ", und ist " + randomCloudiness_vormittag);
                forecast.Add(time.ToString("d") + ": In " + zipcode +
                    " hat es nachmittags " + info_nachmittag.Temperature + " " + info_nachmittag.Display + ", und ist " + randomCloudiness_nachmittag);
                forecast.Add(time.ToString("d") + ": In " + zipcode +
                    " hat es nachts " + info_nacht.Temperature + " " + info_nacht.Display + ", und ist " + randomCloudiness_nacht);

                time = time.AddDays(1.0);
            }
            return forecast;
        }

        public List<string> GetFourteenDayForecast(int zipcode, ITemperatureStrategy strategy)
        {
            List<string> forecast = new List<string>();
            DateTime time = DateTime.Today;
            Random random = new Random();

            for (int dayoffset = 0; dayoffset < 14; dayoffset++)
            {
                TemperatureInfo info = strategy.GetTemperatureFromCelsius(random.Next(11, 30));
                string randomCloudiness = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));

                forecast.Add("In " + zipcode + ": " + time.ToString("D", CultureInfo.CreateSpecificCulture("de-DE"))
                    + " hat es " + info.Temperature + " " + info.Display + ", und ist " + randomCloudiness);

                time = time.AddDays(1.0);
            }

            return forecast;
        }
    }
}