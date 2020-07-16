using Functionalities.DomainModels;

namespace Functionalities.Adapter
{
    public class MapperCurrentWeatherDomainModel
    {
        public CurrentWeatherDomainModel MapToCurrentWeatherDomainModel(OpenWeatherCurrentWeatherDataModel datamodel)
        {
            CurrentWeatherDomainModel domainModel = new CurrentWeatherDomainModel();
            domainModel.Temperature = datamodel.Main.Temp;
            domainModel.WeatherDescription = datamodel.Weather[0].Description;

            return domainModel;
        }
    }
}