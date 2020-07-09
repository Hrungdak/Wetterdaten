using Functionalities.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalities.Adapter
{
    public class MapperCurrentWeatherDomainModel
    {
        public CurrentWeatherDomainModel MapToCurrentWeatherDomainModel(OpenWeatherCurrentWeatherDataModel datamodel)
        {
            CurrentWeatherDomainModel domainModel = new CurrentWeatherDomainModel();
            domainModel.Temperature = datamodel.Main.Temp;
            domainModel.Humidity = datamodel.Main.Humidity;
            domainModel.Clouds = datamodel.Weather[0].Main;

            return domainModel;
        }
    }
}