using Nancy.Json;
using shop.Core.Dtos;
using shop.Core.Dtos.Weather;
using shop.Core.ServiceInterface;
using System.Net;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using shop.Dtos.ServiceInterface;

namespace shop.ApplicationServices.Services
{
    public class WeatherForecastServices : IWeatherForecastServices

    {
        public WeatherDto GetResponse(string city)
        {
            throw new System.NotImplementedException();
        }

        public async Task<WeatherDto> WeatherDetail(WeatherDto dto)
        {
            //string apikey = "ba56ad4fa94b4d0ec8ecac5bb9967e0e"; //APi key
            var url = $"http://api.openweathermap.org/geo/1.0/direct?q=Tallinn&limit=5&units=metric&appid=ba56ad4fa94b4d0ec8ecac5bb9967e0e";

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);

                OpenWeatherRootDto weatherInfo = (new JavaScriptSerializer()).Deserialize<OpenWeatherRootDto>(json);

                dto.name = weatherInfo.coord.name;
                dto.main = weatherInfo.weather[0].main;
                dto.description = weatherInfo.weather[0].description;
                dto.icon = weatherInfo.weather[0].icon;

                dto.temp = weatherInfo.main.temp;
                dto.feels_like = weatherInfo.main.feels_like;
                dto.temp_min = weatherInfo.main.temp_min;
                dto.temp_max = weatherInfo.main.temp_max;
                dto.pressure = weatherInfo.main.pressure;
                dto.humidity = weatherInfo.main.humidity;
                dto.visibility = weatherInfo.visibility;

                dto.speed = weatherInfo.wind.speed;
                dto.deg = weatherInfo.wind.deg;

                dto.all = weatherInfo.clouds.all;

                dto.dt = weatherInfo.dt;

                dto.type = weatherInfo.sys.type;
                dto.id = weatherInfo.sys.id;
                dto.message = weatherInfo.sys.message;
                dto.country = weatherInfo.sys.country;
                dto.sunrise = weatherInfo.sys.sunrise;
                dto.sunset = weatherInfo.sys.sunset;
                dto.timezone = weatherInfo.timezone;

                var jsonString = new JavaScriptSerializer().Serialize(dto);

            }
            return dto;
        }

    }
}
