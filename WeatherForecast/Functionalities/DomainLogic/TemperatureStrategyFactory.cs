using Functionalities.Contracts;
using Functionalities.Enums;

namespace Functionalities.DomainLogic
{
    public static class TemperatureStrategyFactory
    {
        public static ITemperatureStrategy GetTemperatureStrategy(TemperatureTypeEnum temperatureType)
        {
            switch (temperatureType)
            {
                case TemperatureTypeEnum.Kelvin:
                    {
                        return new KelvinStrategy();
                    }
                case TemperatureTypeEnum.Fahrenheit:
                    {
                        return new FahrenheitStrategy();
                    }
                default:
                    {
                        return new CelsiusStrategy();
                    }
            }
        }
    }
}