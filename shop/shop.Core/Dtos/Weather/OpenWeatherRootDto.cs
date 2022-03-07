﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Core.Dtos.Weather
{
    public class OpenWeatherRootDto
    {
        public CoordDto coord { get; set; }
        public List<OpenDailyForecastDto> DailyForecasts { get; set; }
    }
}
