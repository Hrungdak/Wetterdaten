using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities
{
    public interface IForecastStrategy
    {
        List<string> GetForecastForStrategy(int zipcode, ITemperatureStrategy temperatureStrategy);
    }
}