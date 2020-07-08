using Functionalities.Exceptions;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Functionalities.DomainModels;

namespace Functionalities.Adapter
{
    public class OpenWeatherAPI
    {
        private static string _url = "";

        //ToDo: Get Country Code by Zip -> get it from UI
        private static string _countryCode = "de";

        private static string _apiKey;

        public OpenWeatherAPI(string apiKey)
        {
            _apiKey = apiKey;
        }

        public async Task<CurrentWeatherDomainModel> GetCurrentWeather(HttpClient apiClient, int zipcode)
        {
            _url = $"http://api.openweathermap.org/data/2.5/weather?zip={zipcode},{_countryCode}&appid={_apiKey}";
            HttpResponseMessage response = await apiClient.GetAsync(_url);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var weatherForecastModel = JsonConvert.DeserializeObject<OpenWeatherCurrentWeatherDataModel>(json);
                return GetWeatherForecastDomainModel(weatherForecastModel);
            }
            else
            {
                throw new Exception($"Zip not found: {zipcode.ToString()}");
            }
        }

        //ToDo Return OneCallApiDomainModel
        //public static async Task<CurrentWeatherDomainModel> GetHourlyForecast(HttpClient apiClient, float latitude, float longitude)
        //{
        //    _url = $"http://api.openweathermap.org/data/2.5/onecall?lat={latitude}&lon={longitude}&appid ={_apiKey}";

        //    try
        //    {
        //        HttpResponseMessage response = await apiClient.GetAsync(_url);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            var json = await response.Content.ReadAsStringAsync();
        //            var weatherForecastModel = JsonConvert.DeserializeObject<CurrentWeatherDataModel>(json);
        //            return GetWeatherForecastDomainModel(weatherForecastModel);
        //        }
        //        else
        //        {
        //            //ToDO: Correct Exception?
        //            throw new HttpRequestException(response.ReasonPhrase);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        private static CurrentWeatherDomainModel GetWeatherForecastDomainModel(OpenWeatherCurrentWeatherDataModel model)
        {
            return new CurrentWeatherDomainModel(model);
        }
    }
}