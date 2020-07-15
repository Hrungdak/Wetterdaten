using Functionalities.Contracts;
using Functionalities.Enums;

namespace Functionalities.DomainLogic
{
    public static class ForecastStrategyFactory
    {
        public static IForecastStrategy GetForecastStrategy(
            ForecastTypeEnum forecastType,
            WeatherForecast weatherForecast)
        {
            switch (forecastType)
            {
                default:
                    {
                        return new EasyForecastStrategy(weatherForecast);
                    }
                case ForecastTypeEnum.hourly:
                    {
                        return new HourlyForecastStrategy(weatherForecast);
                    }
                case ForecastTypeEnum.threeDays:
                    {
                        return new ThreeDayForecastStrategy(weatherForecast);
                    }
                case ForecastTypeEnum.fourteenDays:
                    {
                        return new FourteenDayForecastStrategy(weatherForecast);
                    }
            }
        }
    }
}