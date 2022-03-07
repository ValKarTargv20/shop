using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Core.Dtos.Weather
{
    public class OpenDailyForecastDto
    {
        [JsonProperty("@base")]
        public string @base { get; set; }
        public CloudsDto clouds { get; set; }
        public CoordDto coord { get; set; }
        public MainDto main { get; set; }
        public weatherDto weather { get; set; }

        [JsonProperty("visibility")]
        public int visibility { get; set; }
        public WindDto wind { get; set; }

        [JsonProperty("dt")]
        public int dt { get; set; }
        public SysDto sys { get; set; }

        [JsonProperty("timezone")]
        public int timezone { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("cod")]
        public int cod { get; set; }
    }
}
