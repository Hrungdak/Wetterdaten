using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities
{
    public class TemperatureStrategy : ITemperatureStrategy
    {
        private ITemperatureStrategy _strategy;

        public TemperatureStrategy(TemperatureTypeEnum temperatureType)
        {
            _strategy = GetStrategy(temperatureType);
        }

        private ITemperatureStrategy GetStrategy(TemperatureTypeEnum temperatureType)
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

        public TemperatureInfo GetTemperatureFromCelsius(float celsiusTemperature)
        {
            //ToDo ?????
            return _strategy.GetTemperatureFromCelsius(celsiusTemperature);
        }
    }
}