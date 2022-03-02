using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Core.Dtos.Weather
{
    public class OpenWeatherResultViewModel
    {
        public string @base { get; set; }
        public CloudsDto clouds { get; set; }
        public CoordDto coord { get; set; }
        public MainDto main { get; set; }
        public List<WeatherDto> weather { get; set; }
        public int visibility { get; set; }
        public WindDto wind { get; set; }
        public int dt { get; set; }
        public SysDto sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }
}
