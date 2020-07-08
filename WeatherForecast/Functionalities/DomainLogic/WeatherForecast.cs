using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Functionalities.Adapter;
using Functionalities.DomainModels;
using Functionalities.Enums;

namespace Functionalities.DomainLogic
{
    public class WeatherForecast
    {
        private HttpClient httpClient = HttpClientFactory.CreateClient();

        public string GetWeatherForecastForZip(int zipcode, DateTime date)
        {
            //ToDo Next Steps:
            // Get Data from the CurrentWeatherDataModel
            // Return current Temperature.
            //Adjust string output to be correct (zip, date, temperature, degree Type, cloudiness)
            //try
            //{
                var result = Task.Run(() => OpenWeatherAPI.GetCurrentWeather(httpClient, zipcode));

                result.Wait();

                CurrentWeatherDomainModel model = result.Result;

                float temperature = model.Temperature;
                string cloudiness = model.Clouds;

                //Random random = new Random();
                //int randomTemperature = random.Next(11, 30);
                //string randomCloudiness = Enum.GetName(typeof(CloudinessEnum), random.Next(0, Enum.GetNames(typeof(CloudinessEnum)).Length));

                return $"In {zipcode} hat es am {date.ToString("dd.MM.yyyy")} {temperature} °C und es ist {cloudiness}";
            //}
            //catch
            //{
            //    throw;
            //}
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