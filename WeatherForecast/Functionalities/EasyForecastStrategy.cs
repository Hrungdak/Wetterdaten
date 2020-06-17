using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities
{
    internal class EasyForecastStrategy : IForecastStrategy
    {
        List<string> IForecastStrategy.GetForecastForStrategy(int zipcode, ITemperatureStrategy temperatureStrategy)
        {
            List<string> forecast = new List<string>();
            DateTime time = DateTime.Today;
            Random random = new Random();
            TemperatureInfo info = temperatureStrategy.GetTemperatureFromCelsius(random.Next(11, 30));
            string randomCloudiness = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));
            forecast.Add(time.ToString("D") + ": In " + zipcode +
                    " hat es " + info.Temperature + " " + info.Display + ", und ist " + randomCloudiness);
            return forecast;
        }
    }
}