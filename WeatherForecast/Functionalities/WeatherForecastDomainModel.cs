using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities
{
    public class WeatherForecastDomainModel
    {
        public float Temperature { get; }
        public int Humidity { get; }
        public string Clouds { get; }

        public WeatherForecastDomainModel(WeatherForecastModel model)
        {
            Temperature = model.Main.Temp;
            Humidity = model.Main.Humidity;
            Clouds = model.Weather[0].Main;
        }
    }
}