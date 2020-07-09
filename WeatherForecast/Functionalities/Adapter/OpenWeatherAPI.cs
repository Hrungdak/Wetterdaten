using Functionalities.Exceptions;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Functionalities.DomainModels;
using Functionalities.Contracts;

namespace Functionalities.Adapter
{
    public class OpenWeatherAPI
    {
        private static string _url = "";

        //ToDo: Get Country Code -> get it from UI
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
                return GetCurrentWeatherForecastDomainModel(weatherForecastModel);
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
        //            throw new HttpRequestException(response.ReasonPhrase);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        private static CurrentWeatherDomainModel GetCurrentWeatherForecastDomainModel(OpenWeatherCurrentWeatherDataModel model)
        {
            MapperCurrentWeatherDomainModel mapper = new MapperCurrentWeatherDomainModel();
            return mapper.MapToCurrentWeatherDomainModel(model);
        }

        private static HourlyValuesDomainModel GetOneCallApiDomainModel(OpenWeatherOneCallApiDataModel model)
        {
            //ToDo DI benutzen
            IMapperHourlyValuesDomainModel<OpenWeatherOneCallApiDataModel> mapper = new MapperOpenWeatherOneCallToHourlyValuesDomainModel();
            return mapper.MapToHourlyValuesDomainModel(model);
        }
    }
}