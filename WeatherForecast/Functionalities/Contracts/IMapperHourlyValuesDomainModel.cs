using Functionalities.Adapter;
using Functionalities.DomainModels;

namespace Functionalities.Contracts
{
    public interface IMapperHourlyValuesDomainModel
    {
        HourlyValuesDomainModel MapToHourlyValuesDomainModel(OpenWeatherOneCallApiDataModel model);
    }
}