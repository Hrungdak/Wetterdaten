using Functionalities.Contracts;
using Functionalities.Enums;

namespace Functionalities.DomainLogic
{
    public class FahrenheitStrategy : ITemperatureStrategy
    {
        public TemperatureInfo GetTemperatureFromKelvin(float kelvinTemperature)
        {
            TemperatureInfo temperatureInfo = new TemperatureInfo();
            temperatureInfo.Temperature = kelvinTemperature - 459;
            temperatureInfo.Display = "F";
            temperatureInfo.Type = TemperatureTypeEnum.Fahrenheit;
            return temperatureInfo;
        }
    }
}