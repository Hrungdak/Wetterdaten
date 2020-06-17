﻿using System;
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
            return new ForecastStrategy(forecastType);
        }

        private ITemperatureStrategy GetTemperatureStrategy(TemperatureTypeEnum temperatureType)
        {
            return new TemperatureStrategy(temperatureType);
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