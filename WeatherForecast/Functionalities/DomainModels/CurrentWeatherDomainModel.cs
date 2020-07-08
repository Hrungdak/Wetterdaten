using Functionalities.Adapter;

namespace Functionalities.DomainModels
{
    public class CurrentWeatherDomainModel
    {
        public float Temperature { get; }
        public int Humidity { get; }
        public string Clouds { get; }

        // TODO: Alex: Mapping muss in den Adapter, DomainModel darf keine Referenz auf OpenWeatherCurrentWeatherDataModel haben
        public CurrentWeatherDomainModel(OpenWeatherCurrentWeatherDataModel model)
        {
            Temperature = model.Main.Temp;
            Humidity = model.Main.Humidity;
            Clouds = model.Weather[0].Main;
        }
    }
}