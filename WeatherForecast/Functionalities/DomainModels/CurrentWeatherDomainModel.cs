namespace Functionalities
{
    public class CurrentWeatherDomainModel
    {
        public float Temperature { get; }
        public int Humidity { get; }
        public string Clouds { get; }

        public CurrentWeatherDomainModel(OpenWeatherCurrentWeatherDataModel model)
        {
            Temperature = model.Main.Temp;
            Humidity = model.Main.Humidity;
            Clouds = model.Weather[0].Main;
        }
    }
}