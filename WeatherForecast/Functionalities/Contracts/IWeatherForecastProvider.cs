using Functionalities.DomainModels;
using System.Threading.Tasks;

namespace Functionalities.Contracts
{
    public interface IWeatherForecastProvider
    {
        Task<CurrentWeatherDomainModel> GetCurrentWeather(int zipcode);

        Task<HourlyValuesDomainModel> GetHourlyWeather(int zipcode);

        Task<ThreeDayValuesDomainModel> GetWeatherForThreeDays(int zipcode);

        Task<FourteenDayValuesDomainModel> GetWeatherForFourteenDays(int zipcode);
    }
}