using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities
{
    public class ForecastStrategy : IForecastStrategy
    {
        private IForecastStrategy _strategy;

        public ForecastStrategy(ForecastTypeEnum forecastType)
        {
            _strategy = GetStrategy(forecastType);
        }

        private IForecastStrategy GetStrategy(ForecastTypeEnum forecastType)
        {
            switch (forecastType)
            {
                default:
                    {
                        return new EasyForecastStrategy();
                    }
                case ForecastTypeEnum.hourly:
                    {
                        return new HourlyForecastStrategy();
                    }
                case ForecastTypeEnum.threeDays:
                    {
                        return new ThreeDayForecastStrategy();
                    }
                case ForecastTypeEnum.fourteenDays:
                    {
                        return new FourteenDayForecastStrategy();
                    }
            }
        }

        public List<string> GetForecastForStrategy(int zipcode, ITemperatureStrategy temperatureStrategy)
        {
            //ToDo ?????
            return _strategy.GetForecastForStrategy(zipcode, temperatureStrategy);
        }
    }
}