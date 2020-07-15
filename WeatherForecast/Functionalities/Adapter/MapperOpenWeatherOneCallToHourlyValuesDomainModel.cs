using Functionalities.Contracts;
using Functionalities.DomainModels;
using System;
using System.Collections.Generic;

namespace Functionalities.Adapter
{
    public class MapperOpenWeatherOneCallToHourlyValuesDomainModel : IMapperHourlyValuesDomainModel<OpenWeatherOneCallApiDataModel>
    {
        public HourlyValuesDomainModel MapToHourlyValuesDomainModel(OpenWeatherOneCallApiDataModel model)
        {
            HourlyValuesDomainModel domainModel = new HourlyValuesDomainModel();
            domainModel.HourlyValues = new List<HourlyDomainModel>();
            foreach (var hourly in model.Hourly)
            {
                domainModel.HourlyValues.Add(MapToHourlyValueDomainModel(hourly));
            }

            return domainModel;
        }

        private HourlyDomainModel MapToHourlyValueDomainModel(Hourly hourly)
        {
            var result = new HourlyDomainModel();
            result.Time = new DateTime(1970, 1, 1).AddSeconds(hourly.Dt);
            result.Temperature = hourly.Temp;
            result.Humidity = hourly.Humidity;
            result.Cloudiness = hourly.Clouds;

            return result;
        }
    }
}