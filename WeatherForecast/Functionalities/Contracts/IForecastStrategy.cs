using System;
using System.Collections.Generic;

namespace Functionalities.Contracts
{
    public interface IForecastStrategy
    {
        List<string> GetForecast(int zipcode, ITemperatureStrategy temperatureStrategy, DateTime date);
    }
}