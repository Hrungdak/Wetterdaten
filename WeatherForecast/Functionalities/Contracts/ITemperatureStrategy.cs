using Functionalities.DomainLogic;

namespace Functionalities.Contracts
{
    public interface ITemperatureStrategy
    {
        TemperatureInfo GetTemperatureFromKelvin(float kelvinTemperature);
    }
}