using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Core.Dtos.Weather
{
    class OpenWeatherRootDto
    {
        public HeadlineDto Headline { get; set; }
        public List<DailyForecastDto> DailyForecasts { get; set; }
    }
}
