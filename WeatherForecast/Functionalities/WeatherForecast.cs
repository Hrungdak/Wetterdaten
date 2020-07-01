using System;
using System.Collections.Generic;
using System.Globalization;

namespace Functionalities
{
    public class WeatherForecast
    {
        public string GetWeatherForecastForZip(int zipcode, DateTime date)
        {
            Random random = new Random();
            int randomTemperature = random.Next(11, 30);
            string randomCloudiness = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));

            return $"In {zipcode} hat es am {date.ToString("dd.MM.yyyy")} {randomTemperature} °C und es ist {randomCloudiness}";
        }

        public List<string> GetHourlyWeatherForecast(int zipcode, DateTime date)
        {
            List<string> result = new List<string>();
            TimeSpan twelveAM = new TimeSpan(0, 0, 0);
            DateTime dateAtTwelveAM = date.Date + twelveAM;
            Random random = new Random();
            for (int hourOfDay = 0; hourOfDay < 24; hourOfDay++)
            {
                int randomTemperature = random.Next(11, 30);
                string randomCloudiness = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));
                result.Add($"{dateAtTwelveAM.ToString()}: In {zipcode} hat es {randomTemperature} °C und ist {randomCloudiness}");
                dateAtTwelveAM = dateAtTwelveAM.AddHours(1.0);
            }

            return result;
        }
    }
}