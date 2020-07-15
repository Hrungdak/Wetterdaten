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

        private OpenWeatherOneCallDomainModel _openWeatherOneCallDomainModel;

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

        public async Task<HourlyValuesDomainModel> GetHourlyWeather(HttpClient apiClient, int zipcode)
        {
            await GetOpenWeatherOneCallDomainModel(apiClient, zipcode);
            return _openWeatherOneCallDomainModel.HourlyValuesDomainModel;
        }

        public async Task<ThreeDayValuesDomainModel> GetWeatherForThreeDays(HttpClient apiClient, int zipcode)
        {
            await GetOpenWeatherOneCallDomainModel(apiClient, zipcode);
            return _openWeatherOneCallDomainModel.ThreeDayValuesDomainModel;
        }

        public async Task<FourteenDayValuesDomainModel> GetWeatherForFourteenDays(HttpClient apiClient, int zipcode)
        {
            await GetOpenWeatherOneCallDomainModel(apiClient, zipcode);
            return _openWeatherOneCallDomainModel.FourteenDayValuesDomain;
        }

        private async Task GetOpenWeatherOneCallDomainModel(HttpClient apiClient, int zipcode)
        {
            _openWeatherOneCallDomainModel = await GetOneCallApiDataModel(apiClient, zipcode);
        }

        private async Task<OpenWeatherOneCallDomainModel> GetOneCallApiDataModel(HttpClient apiClient, int zipcode)
        {
            //ToDo: Get Lat, Lon from zipcode
            string latitude = "48.14";
            string longitude = "11.58";

            _url = $"https://api.openweathermap.org/data/2.5/onecall?lat={latitude}&lon={longitude}&appid={_apiKey}";

            try
            {
                HttpResponseMessage response = await apiClient.GetAsync(_url);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var weatherForecastModel = JsonConvert.DeserializeObject<OpenWeatherOneCallApiDataModel>(json);
                    OpenWeatherOneCallDomainModel openWeatherOneCallDomainModel = new OpenWeatherOneCallDomainModel();
                    openWeatherOneCallDomainModel.HourlyValuesDomainModel = GetHourlyValuesDomainModelFromOneCallApiDataModel(weatherForecastModel);
                    openWeatherOneCallDomainModel.ThreeDayValuesDomainModel = GetThreeDayValuesDomainModelFromOneCallApiDataModel(weatherForecastModel);
                    openWeatherOneCallDomainModel.FourteenDayValuesDomain = GetFourteenDayValuesDomainModelFromOneCallApiDataModel(weatherForecastModel);
                    return openWeatherOneCallDomainModel;
                }
                else
                {
                    throw new HttpRequestException(response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static CurrentWeatherDomainModel GetCurrentWeatherForecastDomainModel(OpenWeatherCurrentWeatherDataModel model)
        {
            MapperCurrentWeatherDomainModel mapper = new MapperCurrentWeatherDomainModel();
            return mapper.MapToCurrentWeatherDomainModel(model);
        }

        private static HourlyValuesDomainModel GetHourlyValuesDomainModelFromOneCallApiDataModel(OpenWeatherOneCallApiDataModel model)
        {
            //ToDo DI benutzen
            IMapperHourlyValuesDomainModel<OpenWeatherOneCallApiDataModel> mapper = new MapperOpenWeatherOneCallToHourlyValuesDomainModel();
            return mapper.MapToHourlyValuesDomainModel(model);
        }

        private static ThreeDayValuesDomainModel GetThreeDayValuesDomainModelFromOneCallApiDataModel(OpenWeatherOneCallApiDataModel model)
        {
            IMapperThreeDayValuesDomainModel<OpenWeatherOneCallApiDataModel> mapper = new MapperOpenWeatherOneCallToThreeDayValuesDomainModel();
            return mapper.MapToThreeDayValuesDomainModel(model);
        }

        private static FourteenDayValuesDomainModel GetFourteenDayValuesDomainModelFromOneCallApiDataModel(OpenWeatherOneCallApiDataModel model)
        {
            IMapperFourteenDayValuesDomainModel<OpenWeatherOneCallApiDataModel> mapper = new MapperOpenWeatherOneCallToFourteenDayValuesDomainModel();
            return mapper.MapToFourteenDayValuesDomainModel(model);
        }
    }
}