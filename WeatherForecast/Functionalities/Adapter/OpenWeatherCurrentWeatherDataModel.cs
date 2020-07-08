using System.Collections.Generic;

namespace Functionalities
{
    public class CurrentWeatherDataModel
    {
        public string Base { get; set; }
        public int Visibility { get; set; }
        public int Dt { get; set; }
        public int Timezone { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }

        public Coord Coord { get; set; }

        public List<Weather> Weather { get; set; }

        public Main Main { get; set; }

        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public Sys Sys { get; set; }
    }
}