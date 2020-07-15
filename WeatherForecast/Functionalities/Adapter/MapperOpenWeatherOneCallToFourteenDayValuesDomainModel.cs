using Functionalities.Contracts;
using Functionalities.DomainModels;
using System;
using System.Collections.Generic;

namespace Functionalities.Adapter
{
    public class MapperOpenWeatherOneCallToFourteenDayValuesDomainModel : IMapperFourteenDayValuesDomainModel<OpenWeatherOneCallApiDataModel>
    {
        public FourteenDayValuesDomainModel MapToFourteenDayValuesDomainModel(OpenWeatherOneCallApiDataModel model)
        {
            FourteenDayValuesDomainModel domainmodel = new FourteenDayValuesDomainModel();
            domainmodel.FourteenDayValues = new List<FourteenDayDomainModel>();
            //ToDo: Important - API only returns 7 Days instead of 14 Days!!!
            for (int i = 0; i < 7; i++)
            {
                domainmodel.FourteenDayValues.Add(MapToFourteenDayValueDomainModel(model.Daily[i]));
            }

            return domainmodel;
        }

        private FourteenDayDomainModel MapToFourteenDayValueDomainModel(Daily daily)
        {
            var result = new FourteenDayDomainModel();
            result.Time = new DateTime(1970, 1, 1).AddSeconds(daily.Dt);
            result.Temperature = daily.Temp.Day;
            result.Humidity = daily.Humidity;
            result.Cloudiness = daily.Clouds;

            return result;
        }
    }
}