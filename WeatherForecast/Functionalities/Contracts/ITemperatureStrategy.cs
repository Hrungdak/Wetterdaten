using Functionalities.DomainLogic;

namespace Functionalities.Contracts
{
    public interface ITemperatureStrategy
    {
        //ToDo OpenWeatherAPI has Kelvin as Default, adjust Method.
        TemperatureInfo GetTemperatureFromCelsius(float celsiusTemperature);
    }
}