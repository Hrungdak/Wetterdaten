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

        public List<string> GetWeatherForecastForZip(int zipcode, ForecastTypeEnum type)
        {
            switch (type)
            {
                case ForecastTypeEnum.easy:
                    {
                        return GetEasyForecast(zipcode);
                    }

                case ForecastTypeEnum.hourly:
                    {
                        return GetHourlyForecast(zipcode);
                    }

                case ForecastTypeEnum.threeDays:
                    {
                        return GetThreeDayForecast(zipcode);
                    }

                case ForecastTypeEnum.fourteenDays:
                    {
                        return GetFourteenDayForecast(zipcode);
                    }
            }

            return new List<string>()
                    {
                        "Error getting Forecast"
                    };
        }

        public List<string> GetEasyForecast(int zipcode)
        {
            List<string> forecast = new List<string>();
            DateTime time = DateTime.Today;
            Random random = new Random();
            int randomTemperature = random.Next(11, 30);
            string randomCloudiness = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));

            forecast.Add(time.ToString("D") + ": In " + zipcode +
                    " hat es " + randomTemperature + " C°, und ist " + randomCloudiness);
            return forecast;
        }

        public List<string> GetHourlyForecast(int zipcode)
        {
            List<string> forecast = new List<string>();
            DateTime time = DateTime.Today;
            Random random = new Random();
            for (int hourOfDay = 0; hourOfDay < 24; hourOfDay++)
            {
                int randomTemperature = random.Next(11, 30);
                string randomCloudiness = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));

                forecast.Add(time.ToString() + ": In " + zipcode +
                    " hat es " + randomTemperature + " C°, und ist " + randomCloudiness);
                time = time.AddHours(1.0);
            }

            return forecast;
        }

        public List<string> GetThreeDayForecast(int zipcode)
        {
            List<string> forecast = new List<string>();
            DateTime time = DateTime.Today;
            Random random = new Random();
            for (int dayoffset = 0; dayoffset < 3; dayoffset++)
            {
                int randomTemperature_vormittag = random.Next(11, 30);
                int randomTemperature_nachmittag = random.Next(11, 30);
                int randomTemperature_nacht = random.Next(11, 30);
                string randomCloudiness_vormittag = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));
                string randomCloudiness_nachmittag = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));
                string randomCloudiness_nacht = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));

                forecast.Add(time.ToString("d") + ": In " + zipcode +
                    " hat es vormittags " + randomTemperature_vormittag + " C°, und ist " + randomCloudiness_vormittag);
                forecast.Add(time.ToString("d") + ": In " + zipcode +
                    " hat es nachmittags " + randomTemperature_nachmittag + " C°, und ist " + randomCloudiness_nachmittag);
                forecast.Add(time.ToString("d") + ": In " + zipcode +
                    " hat es nachts " + randomTemperature_nacht + " C°, und ist " + randomCloudiness_nacht);

                time = time.AddDays(1.0);
            }
            return forecast;
        }

        public List<string> GetFourteenDayForecast(int zipcode)
        {
            List<string> forecast = new List<string>();
            DateTime time = DateTime.Today;
            Random random = new Random();
            for (int dayoffset = 0; dayoffset < 14; dayoffset++)
            {
                int randomTemperature = random.Next(11, 30);
                string randomCloudiness = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));

                forecast.Add("In " + zipcode + ": " + time.ToString("D", CultureInfo.CreateSpecificCulture("de-DE"))
                    + " hat es " + randomTemperature + " C°, und ist " + randomCloudiness);

                time = time.AddDays(1.0);
            }

            return forecast;
        }
    }
}