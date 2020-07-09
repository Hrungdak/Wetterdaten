using Functionalities.Contracts;
using Functionalities.Enums;

namespace Functionalities.DomainLogic
{
    public class CelsiusStrategy : ITemperatureStrategy
    {
        public TemperatureInfo GetTemperatureFromKelvin(float kelvinTemperature)
        {
            TemperatureInfo temperatureInfo = new TemperatureInfo();
            temperatureInfo.Temperature = kelvinTemperature - 273;
            temperatureInfo.Display = "°C";
            temperatureInfo.Type = TemperatureTypeEnum.Celsius;
            return temperatureInfo;
        }
    }
}