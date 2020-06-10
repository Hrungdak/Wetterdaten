using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities
{
    public interface ITemperatureStrategy
    {
        TemperatureInfo GetTemperatureFromCelsius(float celsiusTemperature);
    }
}