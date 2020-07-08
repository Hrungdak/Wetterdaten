using Functionalities.Contracts;
using Functionalities.Enums;

namespace Functionalities.DomainLogic
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