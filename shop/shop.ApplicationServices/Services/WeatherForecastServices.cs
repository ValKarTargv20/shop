using RestSharp;
using shop.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ApplicationServices.Services
{
    public class WeatherForecastServices
    {
        public async Task<WeatherDto>WeatherResponse()
        {
            string idWeather = "UoEbvX4qtjcv0BWpsIRpKpFN2BPf98ML"; //aoikey from accuweather
            //connection string
            var client = new RestClient($"http://dataservice.accuweather.com/forecasts/v1/daily/1day/");
            var client1 = new RestClient($"http://dataservice.accuweather.com/forecasts/v1/daily/1day/127964?apikey=UoEbvX4qtjcv0BWpsIRpKpFN2BPf98ML&language=en-us&details=false&metric=true");
            return null;
        }
        

    }
}
