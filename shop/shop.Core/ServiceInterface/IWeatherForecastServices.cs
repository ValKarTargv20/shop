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
        Task<OpenWeather> WeatherDetail(OpenWeather dto);

        //WeatherResultDto GetForcast(string city);
    }
}
