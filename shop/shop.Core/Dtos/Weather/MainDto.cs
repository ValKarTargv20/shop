using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Core.Dtos.Weather
{
    public class MainDto
    {
        [JsonProperty("temp")]
        public float temp { get; set; }
        [JsonProperty("feels_like")]
        public float feels_like { get; set; }
        [JsonProperty("temp_min")]
        public float temp_min { get; set; }
        [JsonProperty("temp_max")]
        public float temp_max { get; set; }
        [JsonProperty("pressure")]
        public Int64 pressure { get; set; }
        [JsonProperty("humidity")]
        public int humidity { get; set; }

    }
}
