using Functionalities.DomainModels;

namespace Functionalities.Contracts
{
    public interface IMapperHourlyValuesDomainModel<T>
    {
        HourlyValuesDomainModel MapToHourlyValuesDomainModel(T model);
    }
}