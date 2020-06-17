using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities
{
    internal class ThreeDayForecastStrategy : IForecastStrategy
    {
        public List<string> GetForecastForStrategy(int zipcode, ITemperatureStrategy temperatureStrategy)
        {
            List<string> forecast = new List<string>();
            DateTime time = DateTime.Today;
            Random random = new Random();
            for (int dayoffset = 0; dayoffset < 3; dayoffset++)
            {
                TemperatureInfo info_vormittag = temperatureStrategy.GetTemperatureFromCelsius(random.Next(11, 30));
                TemperatureInfo info_nachmittag = temperatureStrategy.GetTemperatureFromCelsius(random.Next(11, 30));
                TemperatureInfo info_nacht = temperatureStrategy.GetTemperatureFromCelsius(random.Next(11, 30));
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
    }
}