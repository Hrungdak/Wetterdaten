using Functionalities.Contracts;
using Functionalities.Enums;

namespace Functionalities.DomainLogic
{
    public class KelvinStrategy : ITemperatureStrategy
    {
        public TemperatureInfo GetTemperatureFromKelvin(float kelvinTemperature)
        {
            TemperatureInfo temperatureInfo = new TemperatureInfo();
            temperatureInfo.Temperature = kelvinTemperature;
            temperatureInfo.Display = "K";
            temperatureInfo.Type = TemperatureTypeEnum.Kelvin;
            return temperatureInfo;
        }
    }
}