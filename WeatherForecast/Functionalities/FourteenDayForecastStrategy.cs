using System;
using System.Collections.Generic;
using System.Globalization;

namespace Functionalities
{
    internal class FourteenDayForecastStrategy : IForecastStrategy
    {
        public List<string> GetForecastForStrategy(int zipcode, ITemperatureStrategy temperatureStrategy)
        {
            List<string> forecast = new List<string>();
            DateTime time = DateTime.Today;
            Random random = new Random();

            for (int dayoffset = 0; dayoffset < 14; dayoffset++)
            {
                TemperatureInfo info = temperatureStrategy.GetTemperatureFromCelsius(random.Next(11, 30));
                string randomCloudiness = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));

                forecast.Add("In " + zipcode + ": " + time.ToString("D", CultureInfo.CreateSpecificCulture("de-DE"))
                    + " hat es " + info.Temperature + " " + info.Display + ", und ist " + randomCloudiness);

                time = time.AddDays(1.0);
            }

            return forecast;
        }
    }
}