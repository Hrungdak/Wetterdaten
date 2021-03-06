﻿using System.Collections.Generic;

namespace Functionalities.Adapter
{
    public class Current
    {
        public int Dt { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
        public float Temp { get; set; }
        public float Feels_like { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public float Dew_point { get; set; }
        public float Uvi { get; set; }
        public int Clouds { get; set; }
        public float Wind_speed { get; set; }
        public int Wind_deg { get; set; }

        public List<Weather> Weather { get; set; }
        public Rain Rain { get; set; }
    }
}