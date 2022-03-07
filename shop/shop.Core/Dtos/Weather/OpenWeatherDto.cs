using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Core.Dtos.Weather
{
    public class OpenWeatherDto
    {

        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("main")]
        public string main { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
        [JsonProperty("icon")]
        public string icon { get; set; }

    }

    public class OpenWeatherRoot
    {
        public CoordDto coord { get; set; }
        public List<weatherDto> weather { get; set; }
        [JsonProperty("base")]
        //public string @base {get;set;}
        public MainDto main { get; set; }
        [JsonProperty("visibility")]
        public Int64 visibility { get; set; }
        public WindDto wind { get; set; }

        [JsonProperty("dt")]
        public Int64 dt { get; set; }
        [JsonProperty("timezone")]
        public Int64 timezone { get; set; }
        [JsonProperty("id")]
        public Int64 id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("cod")]
        public int cod { get; set; }

    }

    public class CoordDto
    {
        [JsonProperty("name")]
        public string name { get; set; }
    }
}
