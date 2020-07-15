using Functionalities.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities.Contracts
{
    public interface IMapperFourteenDayValuesDomainModel<T>
    {
        FourteenDayValuesDomainModel MapToFourteenDayValuesDomainModel(T model);
    }
}