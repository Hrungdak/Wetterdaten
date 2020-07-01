using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities
{
    public interface IForecastStrategy
    {
        List<string> GetForecastStrategy(int zipcode, ITemperatureStrategy temperatureStrategy, DateTime date);
    }
}