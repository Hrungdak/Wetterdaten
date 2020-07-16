using Functionalities.Contracts;
using Functionalities.DomainModels;
using System;
using System.Collections.Generic;

namespace Functionalities.Adapter
{
    public class MapperOpenWeatherOneCallToFourteenDayValuesDomainModel : IMapperFourteenDayValuesDomainModel
    {
        public FourteenDayValuesDomainModel MapToFourteenDayValuesDomainModel(OpenWeatherOneCallApiDataModel model)
        {
            FourteenDayValuesDomainModel domainmodel = new FourteenDayValuesDomainModel();
            domainmodel.FourteenDayValues = new List<FourteenDayDomainModel>();
            for (int i = 0; i < 7; i++)
            {
                domainmodel.FourteenDayValues.Add(MapToFourteenDayValueDomainModel(model.Daily[i]));
            }
            for (int noDataIndex = 7; noDataIndex < 14; noDataIndex++)
            {
                domainmodel.FourteenDayValues.Add(CreateEmptyDomainModel());
            }

            return domainmodel;
        }

        private FourteenDayDomainModel MapToFourteenDayValueDomainModel(Daily daily)
        {
            var result = new FourteenDayDomainModel();
            result.Time = new DateTime(1970, 1, 1).AddSeconds(daily.Dt);
            result.Temperature = daily.Temp.Day;
            result.WeatherDescription = daily.Weather[0].Description;

            return result;
        }

        private FourteenDayDomainModel CreateEmptyDomainModel()
        {
            var result = new FourteenDayDomainModel();
            result.Time = new DateTime(1970, 1, 1);
            result.Temperature = -999;
            result.WeatherDescription = "Empty Data";

            return result;
        }
    }
}