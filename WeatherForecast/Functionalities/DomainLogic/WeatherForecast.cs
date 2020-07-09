﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Functionalities.Adapter;
using Functionalities.Contracts;
using Functionalities.DomainModels;
using Functionalities.Enums;

namespace Functionalities.DomainLogic
{
    public class WeatherForecast
    {
        private HttpClient httpClient = HttpClientFactory.CreateClient();

        public string GetWeatherForecastForZip(int zipcode, ITemperatureStrategy temperatureStrategy, DateTime date)
        {
            //ToDo Next Steps: Adjust string output to be correct (cloudiness)

            //ToDo: Get API Key from Settings
            OpenWeatherAPI openWeatherAPI = new OpenWeatherAPI("a1fcc507923163ff1bae113a80d8f82a");
            var result = Task.Run(() => openWeatherAPI.GetCurrentWeather(httpClient, zipcode));
            result.Wait();
            CurrentWeatherDomainModel model = result.Result;

            float temperatureKelvin = model.Temperature;
            string cloudiness = model.Clouds;
            TemperatureInfo temperatureInfo = temperatureStrategy.GetTemperatureFromKelvin(temperatureKelvin);

            return $"In {zipcode} hat es am {date.ToString("dd.MM.yyyy")} {temperatureInfo.Temperature} {temperatureInfo.Display} und es ist {cloudiness}";
        }

        public List<string> GetHourlyWeatherForecast(int zipcode, DateTime date)
        {
            //ToDo Next Steps:
            // Get Data from OneCallApiModel
            // read out Hourly Data
            // return it
            List<string> result = new List<string>();
            TimeSpan twelveAM = new TimeSpan(0, 0, 0);
            DateTime dateAtTwelveAM = date.Date + twelveAM;
            Random random = new Random();
            for (int hourOfDay = 0; hourOfDay < 24; hourOfDay++)
            {
                int randomTemperature = random.Next(11, 30);
                string randomCloudiness = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));
                result.Add($"{dateAtTwelveAM.ToString()}: In {zipcode} hat es {randomTemperature} °C und ist {randomCloudiness}");
                dateAtTwelveAM = dateAtTwelveAM.AddHours(1.0);
            }

            return result;
        }
    }
}