using Functionalities.Contracts;
using Functionalities.DomainModels;
using System;
using System.Collections.Generic;

namespace Functionalities.Adapter
{
    public class MapperOpenWeatherOneCallToThreeDayValuesDomainModel : IMapperThreeDayValuesDomainModel
    {
        public ThreeDayValuesDomainModel MapToThreeDayValuesDomainModel(OpenWeatherOneCallApiDataModel model)
        {
            ThreeDayValuesDomainModel domainmodel = new ThreeDayValuesDomainModel();
            domainmodel.ThreeDayValues = new List<ThreeDayDomainModel>();
            for (int i = 0; i < 3; i++)
            {
                domainmodel.ThreeDayValues.Add(MapToThreeDayValueDomainModel(model.Daily[i]));
            }

            return domainmodel;
        }

        private ThreeDayDomainModel MapToThreeDayValueDomainModel(Daily daily)
        {
            var result = new ThreeDayDomainModel();
            result.Time = new DateTime(1970, 1, 1).AddSeconds(daily.Dt);
            result.DailyMorningTemperature = daily.Temp.Morn;
            result.DailyDayTemperature = daily.Temp.Day;
            result.DailyEveningTemperature = daily.Temp.Eve;
            result.WeatherDescription = daily.Weather[0].Description;

            return result;
        }
    }
}