using System;
using System.Collections.Generic;

namespace Functionalities
{
    public class WeatherForecastDomainService
    {
        private ITemperatureStrategy _temperatureStrategy;
        private IForecastStrategy _forecastStrategy;

        public List<string> GetForecast(int zipcode, string datum, TemperatureTypeEnum temperatureType, ForecastTypeEnum forecastType)
        {
            try
            {
                CheckParametersValid(zipcode, datum, temperatureType, forecastType);
            }
            catch (ArgumentException ae)
            {
                //ToDo Fehlermeldung an UI
            }

            _temperatureStrategy = GetTemperatureStrategy(temperatureType);
            _forecastStrategy = GetForecastStrategy(forecastType);
            return _forecastStrategy.GetForecastForStrategy(zipcode, _temperatureStrategy);
        }

        private IForecastStrategy GetForecastStrategy(ForecastTypeEnum forecastType)
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

        private ITemperatureStrategy GetTemperatureStrategy(TemperatureTypeEnum temperatureType)
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

        private void CheckParametersValid(int zipcode, string datum, TemperatureTypeEnum temperatureType, ForecastTypeEnum forecastType)
        {
            //ToDo Validation for Enums
            Validation validation = new Validation();
            if (validation.isZipcode(zipcode) && validation.isStringADate(datum))
            {
            }
            else
            {
                throw new ArgumentException("Invalid Arguments");
            }
        }
    }
}