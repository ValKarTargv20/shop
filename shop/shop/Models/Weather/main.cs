using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Core.Dtos.Weather
{
    public class main
    {
        public float temp { get; set; }
        public float feels_like { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public float temp_min { get; set; }
        public float temp_max { get; set; }
        public float sea_level { get; set; }
        public float grnd_level { get; set; }
    }
}
