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
            switch (type)
            {
                case ForecastTypeEnum.easy:
                    {
                        return GetEasyForecast(zipcode, temperatureType);
                    }

                case ForecastTypeEnum.hourly:
                    {
                        return GetHourlyForecast(zipcode, temperatureType);
                    }

                case ForecastTypeEnum.threeDays:
                    {
                        return GetThreeDayForecast(zipcode, temperatureType);
                    }

                case ForecastTypeEnum.fourteenDays:
                    {
                        return GetFourteenDayForecast(zipcode, temperatureType);
                    }
            }

            return new List<string>()
                    {
                        "Error getting Forecast"
                    };
        }

        public List<string> GetEasyForecast(int zipcode, TemperatureTypeEnum temperatureType)
        {
            List<string> forecast = new List<string>();
            DateTime time = DateTime.Today;
            Random random = new Random();
            string temperatureTypeAsString;

            int randomTemperature = random.Next(11, 30);
            string randomCloudiness = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));
            switch (temperatureType)
            {
                case TemperatureTypeEnum.Kelvin:
                    {
                        temperatureTypeAsString = " K";
                        randomTemperature += 273;
                        break;
                    }
                default:
                    {
                        temperatureTypeAsString = " °C";
                        break;
                    }
            }

            forecast.Add(time.ToString("D") + ": In " + zipcode +
                    " hat es " + randomTemperature + temperatureTypeAsString + ", und ist " + randomCloudiness);
            return forecast;
        }

        public List<string> GetHourlyForecast(int zipcode, TemperatureTypeEnum temperatureType)
        {
            List<string> forecast = new List<string>();
            DateTime time = DateTime.Today;
            Random random = new Random();
            string temperatureTypeAsString;

            for (int hourOfDay = 0; hourOfDay < 24; hourOfDay++)
            {
                int randomTemperature = random.Next(11, 30);
                string randomCloudiness = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));
                switch (temperatureType)
                {
                    case TemperatureTypeEnum.Kelvin:
                        {
                            temperatureTypeAsString = " K";
                            randomTemperature += 273;
                            break;
                        }
                    default:
                        {
                            temperatureTypeAsString = " °C";
                            break;
                        }
                }

                forecast.Add(time.ToString() + ": In " + zipcode +
                    " hat es " + randomTemperature + temperatureTypeAsString + ", und ist " + randomCloudiness);
                time = time.AddHours(1.0);
            }

            return forecast;
        }

        public List<string> GetThreeDayForecast(int zipcode, TemperatureTypeEnum temperatureType)
        {
            List<string> forecast = new List<string>();
            DateTime time = DateTime.Today;
            Random random = new Random();
            string temperatureTypeAsString;
            for (int dayoffset = 0; dayoffset < 3; dayoffset++)
            {
                int randomTemperature_vormittag = random.Next(11, 30);
                int randomTemperature_nachmittag = random.Next(11, 30);
                int randomTemperature_nacht = random.Next(11, 30);
                string randomCloudiness_vormittag = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));
                string randomCloudiness_nachmittag = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));
                string randomCloudiness_nacht = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));

                switch (temperatureType)
                {
                    case TemperatureTypeEnum.Kelvin:
                        {
                            temperatureTypeAsString = " K";
                            randomTemperature_vormittag += 273;
                            randomTemperature_nachmittag += 273;
                            randomTemperature_nacht += 273;
                            break;
                        }
                    default:
                        {
                            temperatureTypeAsString = " °C";
                            break;
                        }
                }

                forecast.Add(time.ToString("d") + ": In " + zipcode +
                    " hat es vormittags " + randomTemperature_vormittag + temperatureTypeAsString + ", und ist " + randomCloudiness_vormittag);
                forecast.Add(time.ToString("d") + ": In " + zipcode +
                    " hat es nachmittags " + randomTemperature_nachmittag + temperatureTypeAsString + ", und ist " + randomCloudiness_nachmittag);
                forecast.Add(time.ToString("d") + ": In " + zipcode +
                    " hat es nachts " + randomTemperature_nacht + temperatureTypeAsString + ", und ist " + randomCloudiness_nacht);

                time = time.AddDays(1.0);
            }
            return forecast;
        }

        public List<string> GetFourteenDayForecast(int zipcode, TemperatureTypeEnum temperatureType)
        {
            List<string> forecast = new List<string>();
            DateTime time = DateTime.Today;
            Random random = new Random();
            string temperatureTypeAsString;

            for (int dayoffset = 0; dayoffset < 14; dayoffset++)
            {
                int randomTemperature = random.Next(11, 30);
                string randomCloudiness = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));

                switch (temperatureType)
                {
                    case TemperatureTypeEnum.Kelvin:
                        {
                            temperatureTypeAsString = " K";
                            randomTemperature += 273;
                            break;
                        }
                    default:
                        {
                            temperatureTypeAsString = " °C";
                            break;
                        }
                }

                forecast.Add("In " + zipcode + ": " + time.ToString("D", CultureInfo.CreateSpecificCulture("de-DE"))
                    + " hat es " + randomTemperature + temperatureTypeAsString + ", und ist " + randomCloudiness);

                time = time.AddDays(1.0);
            }

            return forecast;
        }
    }
}