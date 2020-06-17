using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities
{
    internal class HourlyForecastStrategy : IForecastStrategy
    {
        public List<string> GetForecastForStrategy(int zipcode, ITemperatureStrategy temperatureStrategy)
        {
            List<string> forecast = new List<string>();
            DateTime time = DateTime.Today;
            Random random = new Random();
            for (int hourOfDay = 0; hourOfDay < 24; hourOfDay++)
            {
                string randomCloudiness = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));
                TemperatureInfo info = temperatureStrategy.GetTemperatureFromCelsius(random.Next(11, 30));
                forecast.Add(time.ToString() + ": In " + zipcode +
                    " hat es " + info.Temperature + " " + info.Display + ", und ist " + randomCloudiness);
                time = time.AddHours(1.0);
            }

            return forecast;
        }
    }
}