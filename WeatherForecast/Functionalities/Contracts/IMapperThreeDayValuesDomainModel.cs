using Functionalities.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities.Contracts
{
    public interface IMapperThreeDayValuesDomainModel<T>
    {
        ThreeDayValuesDomainModel MapToThreeDayValuesDomainModel(T model);
    }
}