using System.Collections.Generic;

namespace Functionalities.Adapter
{
    public class OpenWeatherOneCallApiDataModel
    {
        public float Lat { get; set; }
        public float Lon { get; set; }
        public string Timezone { get; set; }
        public int Timezone_offset { get; set; }

        public Current Current { get; set; }

        public List<Hourly> Hourly { get; set; }
        public List<Daily> Daily { get; set; }
    }
}