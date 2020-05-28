using System;

namespace Functionalities
{
    public class WeatherData
    {
        public string GetWeatherForecastForZip(int zipcode)
        {
            Random random = new Random();
            int randomTemperature = random.Next(11, 30);
            string randomCloudiness = Enum.GetName(typeof(Cloudiness), random.Next(0, Enum.GetNames(typeof(Cloudiness)).Length));

            return "In " + zipcode + " hat es heute " + randomTemperature + "°C und es ist " + randomCloudiness;
        }
    }
}