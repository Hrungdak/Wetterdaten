using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Functionalities
{
    public class OpenWeatherAPI
    {
        private static string _url = "";

        //ToDo: Get Country Code by Zip
        private static string _countryCode = "de";

        //ToDo Put API Key into Properties instead of here for Safety
        private static string _apiKey = "a1fcc507923163ff1bae113a80d8f82a";

        public static async Task<WeatherForecastDomainModel> GetCurrentWeather(HttpClient apiClient, int zipcode)
        {
            _url = $"http://api.openweathermap.org/data/2.5/weather?zip={zipcode},{_countryCode}&appid={_apiKey}";
            try
            {
                HttpResponseMessage response = await apiClient.GetAsync(_url);
                if (response.IsSuccessStatusCode)
                {
                    //WeatherForecastModel model = await response.Content.ReadAsAsync<WeatherForecastModel>();
                    var json = await response.Content.ReadAsStringAsync();
                    var weatherForecastModel = JsonConvert.DeserializeObject<WeatherForecastModel>(json);
                    return GetWeatherForecastDomainModel(weatherForecastModel);
                }
                else
                {
                    //ToDO: Correct Exception?
                    throw new HttpRequestException(response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static WeatherForecastDomainModel GetWeatherForecastDomainModel(WeatherForecastModel model)
        {
            return new WeatherForecastDomainModel(model);
        }

        //public static async Task<WeatherForecastModel> GetHourlyForecast(float latitude, float longitude)
        //{
        //    _url = $"api.openweathermap.org/data/2.5/onecall?lat={latitude}&lon={longitude}&appid ={_apiKey}";

        //    using (HttpResponseMessage response = await HttpClientFactory.ApiClient.GetAsync(_url))
        //    {
        //        if (response.IsSuccessStatusCode)
        //        {
        //            WeatherForecastModel model = await response.Content.ReadAsAsync<WeatherForecastModel>();
        //            return model;
        //        }
        //        else
        //        {
        //            //ToDO: Correct Exception?
        //            throw new HttpRequestException(response.ReasonPhrase);
        //        }
        //    }
        //}
    }
}