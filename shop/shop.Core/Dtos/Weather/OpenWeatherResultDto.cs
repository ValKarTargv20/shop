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

        [JsonProperty("main")]
        public string main { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
        [JsonProperty("icon")]
        public string icon { get; set; }

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
        [JsonProperty("visibility")]
        public Int64 visibility { get; set; }

        [JsonProperty("speed")]
        public float speed { get; set; }
        [JsonProperty("deg")]
        public int deg { get; set; }

        [JsonProperty("all")]
        public int all { get; set; }
        [JsonProperty("dt")]
        public Int64 dt { get; set; }
        [JsonProperty("type")]
        public int type { get; set; }
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("message")]
        public float message { get; set; }
        [JsonProperty("country")]
        public string country { get; set; }
        [JsonProperty("sunrise")]
        public Int64 sunrise { get; set; }
        [JsonProperty("sunset")]
        public Int64 sunset { get; set; }

        [JsonProperty("timezone")]
        public Int64 timezone { get; set; }
        //[JsonProperty("id")]
        //public Int64 id { get; set; }
        //[JsonProperty("name")]
        //public string name { get; set; }
        //[JsonProperty("cod")]
        //public int cod { get; set; }

    }
}
