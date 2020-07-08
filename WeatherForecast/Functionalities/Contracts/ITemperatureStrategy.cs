using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities
{
    public interface ITemperatureStrategy
    {
        //ToDo OpenWeatherAPI has Kelvin as Default, adjust Method.
        TemperatureInfo GetTemperatureFromCelsius(float celsiusTemperature);
    }
}