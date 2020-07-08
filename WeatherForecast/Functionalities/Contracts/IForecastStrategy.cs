using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities
{
    public interface IForecastStrategy
    {
        List<string> GetForecast(int zipcode, ITemperatureStrategy temperatureStrategy, DateTime date);
    }
}