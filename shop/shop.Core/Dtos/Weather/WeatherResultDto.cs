using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Core.Dtos.Weather
{
    public class WeatherResultDto
    {
        
        public string EffectiveDate { get; set; }
        
        public Int64 EffectiveEpochDate { get; set; }
        
        public int Severity { get; set; }
        
        public string Text { get; set; }
        //[JsonProperty("Category")]
        public string Category { get; set; }
        //[JsonProperty("EndDate")]
        public string EndDate { get; set; }
        //[JsonProperty("EndEpochDate")]
        public Int64 EndEpochDate { get; set; }
        //[JsonProperty("MobileLink")]
        public string MobileLink { get; set; }
        //[JsonProperty("Link")]
        public string Link { get; set; }

        //DailyForecasts
        //[JsonProperty("Date")]
        public string Date { get; set; }
        //[JsonProperty("EpochDate")]
        public Int64 EpochDate { get; set; }
        //Temperature:
        //Minimum
        //[JsonProperty("TempMinValue")]
        public double TempMinValue { get; set; }
        //[JsonProperty("TempMinUnit")]
        public string TempMinUnit { get; set; }
        //[JsonProperty("TempMinUnitType")]
        public int TempMinUnitType { get; set; }
        //Maximum
        //[JsonProperty("TempMaxValue")]
        public double TempMaxValue { get; set; }
        //[JsonProperty("TempMaxUnit")]
        public string TempMaxUnit { get; set; }
        //[JsonProperty("TempMaxUnitType")]
        public int TempMaxUnitType { get; set; }
        //Day
        //[JsonProperty("DayIcon")]
        public int DayIcon { get; set; }
        //[JsonProperty("DayIconPhrase")]
        public string DayIconPhrase { get; set; }
        //[JsonProperty("DayHasPrecipitation")]
        public bool DayHasPrecipitation { get; set; }
        //[JsonProperty("DayPrecipitationType")]
        public string DayPrecipitationType { get; set; }
        //[JsonProperty("DayPrecipitationIntensity")]
        public string DayPrecipitationIntensity { get; set; }
        //Night
        //[JsonProperty("NightIcon")]
        public int NightIcon { get; set; }
        //[JsonProperty("NightIconPhrase")]
        public string NightIconPhrase { get; set; }
        //[JsonProperty("NightHasPrecipitation")]
        public bool NightHasPrecipitation { get; set; }
        //[JsonProperty("NightPrecipitationType")]
        public string NightPrecipitationType { get; set; }
        //[JsonProperty("NightPrecipitationIntensity")]
        public string NightPrecipitationIntensity { get; set; }


    }
}

