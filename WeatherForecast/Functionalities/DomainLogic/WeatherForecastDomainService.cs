﻿using System;
using System.Collections.Generic;
using Functionalities.Adapter;
using Functionalities.Contracts;
using Functionalities.Enums;
using Functionalities.Exceptions;

namespace Functionalities.DomainLogic
{
    public class WeatherForecastDomainService
    {
        private ITemperatureStrategy _temperatureStrategy;
        private IForecastStrategy _forecastStrategy;

        public List<string> GetForecast(
            int zipcode,
            DateTime date,
            TemperatureTypeEnum temperatureType,
            ForecastTypeEnum forecastType)
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
            // Exercise: New Provider (e.g. Random) and change next Line to see if it still work
            IWeatherForecastProvider weatherForecastProvider = new OpenWeatherAPI(HttpClientFactory.CreateClient(), "a1fcc507923163ff1bae113a80d8f82a");
            WeatherForecast weatherForecast = new WeatherForecast(weatherForecastProvider);
            _forecastStrategy = ForecastStrategyFactory.GetForecastStrategy(forecastType, weatherForecast);
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
            var validation = new UiValidation();
            if (validation.IsZipcode(zipcode) && validation.IsStringADate(date.ToString()))
            {
            }
            else
            {
                throw new ArgumentException("Invalid Arguments");
            }
        }
    }
}