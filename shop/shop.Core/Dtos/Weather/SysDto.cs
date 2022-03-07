﻿using Newtonsoft.Json;

namespace shop.Core.Dtos.Weather
{
    public class SysDto
    {
        [JsonProperty("type")]
        public int type { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("message")]
        public float message { get; set; }

        [JsonProperty("country")]
        public string country { get; set; }

        [JsonProperty("sunrise")]
        public int sunrise { get; set; }

        [JsonProperty("sunset")]
        public int sunset { get; set; }

    }
}