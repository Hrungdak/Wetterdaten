using Functionalities.Adapter;
using Functionalities.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities.Contracts
{
    public interface IMapperThreeDayValuesDomainModel
    {
        ThreeDayValuesDomainModel MapToThreeDayValuesDomainModel(OpenWeatherOneCallApiDataModel model);
    }
}