using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities
{
    internal class CelsiusStrategy : ITemperatureStrategy
    {
        public TemperatureInfo GetTemperatureFromCelsius(float celsiusTemperature)
        {
            TemperatureInfo temperatureInfo = new TemperatureInfo();
            temperatureInfo.Temperature = celsiusTemperature;
            temperatureInfo.Display = "°C";
            temperatureInfo.Type = TemperatureTypeEnum.Celsius;
            return temperatureInfo;
        }
    }
}