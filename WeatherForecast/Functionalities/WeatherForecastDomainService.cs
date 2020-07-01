using System;
using System.Collections.Generic;

namespace Functionalities
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
            return _forecastStrategy.GetForecastStrategy(zipcode, _temperatureStrategy, date);
        }

        private void CheckParametersValid(int zipcode, DateTime date, TemperatureTypeEnum temperatureType, ForecastTypeEnum forecastType)
        {
            //ToDo Validation for Enums
            Validation validation = new Validation();
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