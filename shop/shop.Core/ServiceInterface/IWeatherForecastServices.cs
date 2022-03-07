using shop.Core.Dtos.Weather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Core.ServiceInterface
{
    public interface IWeatherForecastServices
    {
        //string WeatherResponse(string city);
        //Task<WeatherDto> WeatherDetail(WeatherDto dto);

        OpenWeatherResultDto GetForcast(string city);
    }
}
