﻿using Newtonsoft.Json;

namespace shop.Core.Dtos.Weather
{
    public class RainDto
    {
        [JsonProperty("Value")]
        public double Value { get; set; }

        [JsonProperty("Unit")]
        public string Unit { get; set; }

        [JsonProperty("UnitType")]
        public int UnitType { get; set; }
    }
}