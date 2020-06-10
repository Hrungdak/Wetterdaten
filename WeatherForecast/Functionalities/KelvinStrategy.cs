using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities
{
    public class KelvinStrategy : ITemperatureStrategy
    {
        public TemperatureInfo GetTemperatureFromCelsius(float celsiusTemperature)
        {
            TemperatureInfo temperatureInfo = new TemperatureInfo();
            temperatureInfo.Temperature = celsiusTemperature + 273;
            temperatureInfo.Display = "K";
            temperatureInfo.Type = TemperatureTypeEnum.Kelvin;
            return temperatureInfo;
        }
    }
}