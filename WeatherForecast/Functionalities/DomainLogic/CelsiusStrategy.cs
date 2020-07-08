﻿using Functionalities.Contracts;
using Functionalities.Enums;

namespace Functionalities.DomainLogic
{
    public class CelsiusStrategy : ITemperatureStrategy
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