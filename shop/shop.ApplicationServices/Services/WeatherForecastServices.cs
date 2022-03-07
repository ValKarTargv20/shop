using Nancy.Json;
using shop.Core.Dtos;
using shop.Core.Dtos.Weather;
using shop.Core.ServiceInterface;
using System.Net;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace shop.ApplicationServices.Services
{
    public class WeatherForecastServices : IWeatherForecastServices
    {
        public OpenWeatherResultDto GetForcast(string city)
        {
            throw new System.NotImplementedException();
        }

        public async Task<OpenWeatherResultDto> WeatherDetail(OpenWeatherResultDto dto)
        {
            string apikey = "ba56ad4fa94b4d0ec8ecac5bb9967e0e"; //APi key
            var url = $"http://api.openweathermap.org/geo/1.0/direct?q={dto.name}&limit=5&units=metric&appid={apikey}";

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);

                OpenWeatherDto weatherInfo = (new JavaScriptSerializer()).Deserialize<OpenWeatherDto>(json);

                dto.name = weatherInfo.name;
                dto.temp = weatherInfo.main.temp;
                dto.feels_like = weatherInfo.main.feels_like;
                dto.humidity = weatherInfo.main.humidity;
                dto.pressure = weatherInfo.main.pressure;
                dto.speed = weatherInfo.wind.speed;
                dto.main = weatherInfo.weather[0].main;

                var jsonString = new JavaScriptSerializer().Serialize(dto);

            }
            return dto;
        }

    }
}
