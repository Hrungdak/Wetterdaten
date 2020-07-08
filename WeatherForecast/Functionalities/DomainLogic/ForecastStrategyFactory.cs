using Functionalities.Contracts;
using Functionalities.Enums;

namespace Functionalities.DomainLogic
{
    public static class ForecastStrategyFactory
    {
        public static IForecastStrategy GetForecastStrategy(ForecastTypeEnum forecastType)
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
    }
}