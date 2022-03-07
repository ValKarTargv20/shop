using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Core.Dtos.Weather
{
    public class OpenWeatherResultDto
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("temp")]
        public float temp { get; set; }

        [JsonProperty("feels_like")]
        public float feels_like { get; set; }

        [JsonProperty("humidity")]
        public int humidity { get; set; }

        [JsonProperty("pressure")]
        public int pressure { get; set; }

        [JsonProperty("speed")]
        public int speed { get; set; }
        
        [JsonProperty("main")]
        public string main { get; set; } 

    }
}
