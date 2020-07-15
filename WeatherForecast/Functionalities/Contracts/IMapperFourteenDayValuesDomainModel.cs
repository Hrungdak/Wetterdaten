using Functionalities.Adapter;
using Functionalities.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities.Contracts
{
    public interface IMapperFourteenDayValuesDomainModel
    {
        FourteenDayValuesDomainModel MapToFourteenDayValuesDomainModel(OpenWeatherOneCallApiDataModel model);
    }
}