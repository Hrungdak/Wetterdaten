using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Functionalities.Contracts;
using Functionalities.DomainModels;

namespace Functionalities.DomainLogic
{
    public class WeatherForecast
    {
        private HttpClient _httpClient = HttpClientFactory.CreateClient();
        private IWeatherForecastProvider _weatherForecastProvider;

        public WeatherForecast(IWeatherForecastProvider weatherForecastProvider)
        {
            _weatherForecastProvider = weatherForecastProvider;
        }

        public string GetWeatherForecastForZip(int zipcode, ITemperatureStrategy temperatureStrategy, DateTime date)
        {
            //ToDo: Get API Key from Settings
            // Use DI here instead of creating OpenWeatherAPI here ( Provider can be easily changed later)
            // OpenWeatherAPI openWeatherAPI = new OpenWeatherAPI(_httpClient, "a1fcc507923163ff1bae113a80d8f82a");
            var result = Task.Run(() => _weatherForecastProvider.GetCurrentWeather(zipcode));
            result.Wait();
            CurrentWeatherDomainModel model = result.Result;

            float temperatureKelvin = model.Temperature;
            string cloudiness = model.WeatherDescription;
            TemperatureInfo temperatureInfo = temperatureStrategy.GetTemperatureFromKelvin(temperatureKelvin);
            double roundedTemperature = Math.Round(temperatureInfo.Temperature);
            return $"In {zipcode} hat es am {date.ToString("d")} {roundedTemperature} {temperatureInfo.Display} und es ist {cloudiness}";
        }

        public List<string> GetHourlyWeatherForecast(int zipcode, ITemperatureStrategy temperatureStrategy, DateTime date)
        {
            List<string> result = new List<string>();
            var hourlyData = Task.Run(() => _weatherForecastProvider.GetHourlyWeather(zipcode));
            hourlyData.Wait();
            HourlyValuesDomainModel model = hourlyData.Result;
            foreach (var hour in model.HourlyValues)
            {
                TemperatureInfo temperatureInfo = temperatureStrategy.GetTemperatureFromKelvin(hour.Temperature);
                double roundedTemperature = Math.Round(temperatureInfo.Temperature);
                result.Add($"In {zipcode} hat es am {hour.Time.ToString("dd/MM/yyyy, HH:mm")} Uhr {roundedTemperature} {temperatureInfo.Display} und es ist {hour.WeatherDescription}");
            }

            return result;
        }

        public List<string> GetThreeDayWeatherForecast(int zipcode, ITemperatureStrategy temperatureStrategy, DateTime date)
        {
            List<string> result = new List<string>();
            var threeDayData = Task.Run(() => _weatherForecastProvider.GetWeatherForThreeDays(zipcode));
            threeDayData.Wait();
            ThreeDayValuesDomainModel model = threeDayData.Result;
            foreach (var day in model.ThreeDayValues)
            {
                TemperatureInfo MorningTemperatureInfo = temperatureStrategy.GetTemperatureFromKelvin(day.DailyMorningTemperature);
                double roundedMorningTemperature = Math.Round(MorningTemperatureInfo.Temperature);
                TemperatureInfo DayTemperatureInfo = temperatureStrategy.GetTemperatureFromKelvin(day.DailyDayTemperature);
                double roundedDayTemperature = Math.Round(DayTemperatureInfo.Temperature);
                TemperatureInfo EveningTemperatureInfo = temperatureStrategy.GetTemperatureFromKelvin(day.DailyEveningTemperature);
                double roundedEveningTemperature = Math.Round(EveningTemperatureInfo.Temperature);
                result.Add($"In {zipcode} hat es am {day.Time.ToString("d")} morgens {roundedMorningTemperature} {MorningTemperatureInfo.Display} und es ist {day.WeatherDescription}");
                result.Add($"In {zipcode} hat es am {day.Time.ToString("d")} mittags {roundedDayTemperature} {DayTemperatureInfo.Display} und es ist {day.WeatherDescription}");
                result.Add($"In {zipcode} hat es am {day.Time.ToString("d")} mittags {roundedEveningTemperature} {EveningTemperatureInfo.Display} und es ist {day.WeatherDescription}");
            }

            return result;
        }

        public List<string> GetFourteenDayWeatherForecast(int zipcode, ITemperatureStrategy temperatureStrategy, DateTime date)
        {
            List<string> result = new List<string>();
            var fourteenDayData = Task.Run(() => _weatherForecastProvider.GetWeatherForFourteenDays(zipcode));
            fourteenDayData.Wait();
            FourteenDayValuesDomainModel model = fourteenDayData.Result;
            foreach (var day in model.FourteenDayValues)
            {
                TemperatureInfo temperatureInfo = temperatureStrategy.GetTemperatureFromKelvin(day.Temperature);
                double roundedTemperature = Math.Round(temperatureInfo.Temperature);
                result.Add($"In {zipcode} hat es am {day.Time.ToString("d")} {roundedTemperature} {temperatureInfo.Display} und es ist {day.WeatherDescription}");
            }

            return result;
        }
    }
}