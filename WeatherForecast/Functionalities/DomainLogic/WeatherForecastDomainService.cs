using System;
using System.Collections.Generic;
using Functionalities.Contracts;
using Functionalities.Enums;
using Functionalities.Exceptions;

namespace Functionalities.DomainLogic
{
    public class WeatherForecastDomainService
    {
        private ITemperatureStrategy _temperatureStrategy;
        private IForecastStrategy _forecastStrategy;

        public List<string> GetForecast(int zipcode, DateTime date, TemperatureTypeEnum temperatureType, ForecastTypeEnum forecastType)
        {
            try
            {
                CheckParametersValid(zipcode, date, temperatureType, forecastType);
            }
            catch (ArgumentException ae)
            {
                //ToDo Fehlermeldung an UI
            }

            // = "Orchestrierung", ruft Methoden auf ohne zu wissen, woher bspw. Parameter herkommen
            // Funktionales Programmieren
            _temperatureStrategy = TemperatureStrategyFactory.GetTemperatureStrategy(temperatureType);
            _forecastStrategy = ForecastStrategyFactory.GetForecastStrategy(forecastType);
            List<string> result = new List<string>();
            try
            {
                result = _forecastStrategy.GetForecast(zipcode, _temperatureStrategy, date);
            }
            catch (ZipNotFoundException ex)
            {
                result.Add(ex.Message);
            }
            catch (Exception ex)
            {
                result.Add($"Exception: {ex.Message}");
            }
            return result;
        }

        private void CheckParametersValid(int zipcode, DateTime date, TemperatureTypeEnum temperatureType, ForecastTypeEnum forecastType)
        {
            //ToDo Validation for Enums
            var validation = new DomainValidation();
            if (validation.isZipcode(zipcode) && validation.isStringADate(date.ToString()))
            {
            }
            else
            {
                throw new ArgumentException("Invalid Arguments");
            }
        }
    }
}