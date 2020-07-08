using Functionalities.Contracts;
using Functionalities.Enums;

namespace Functionalities.DomainLogic
{
    public class FahrenheitStrategy : ITemperatureStrategy
    {
        public TemperatureInfo GetTemperatureFromCelsius(float celsiusTemperature)
        {
            TemperatureInfo temperatureInfo = new TemperatureInfo();
            temperatureInfo.Temperature = celsiusTemperature + 32;
            temperatureInfo.Display = "F";
            temperatureInfo.Type = TemperatureTypeEnum.Fahrenheit;
            return temperatureInfo;
        }
    }
}