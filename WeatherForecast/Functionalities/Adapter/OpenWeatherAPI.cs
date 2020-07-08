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

        //ToDo: Get Country Code by Zip
        private static string _countryCode = "de";

        //ToDo Put API Key into Properties instead of here for Safety
        private static string _apiKey = "a1fcc507923163ff1bae113a80d8f82a";

        public static async Task<CurrentWeatherDomainModel> GetCurrentWeather(HttpClient apiClient, int zipcode)
        {
            _url = $"http://api.openweathermap.org/data/2.5/weather?zip={zipcode},{_countryCode}&appid={_apiKey}";
            //try
            //{
            HttpResponseMessage response = await apiClient.GetAsync(_url);
            if (response.IsSuccessStatusCode)
            {
                //WeatherForecastModel model = await response.Content.ReadAsAsync<WeatherForecastModel>();
                var json = await response.Content.ReadAsStringAsync();
                var weatherForecastModel = JsonConvert.DeserializeObject<OpenWeatherCurrentWeatherDataModel>(json);
                return GetWeatherForecastDomainModel(weatherForecastModel);
            }
            else
            {
                //ToDO: Correct Exception?
                //throw new ZipNotFoundException(zipcode.ToString());
                throw new Exception($"Zip not found: {zipcode.ToString()}");
            }
            //}
            //catch (Exception ex)
            //{
            //    throw;
            //}
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