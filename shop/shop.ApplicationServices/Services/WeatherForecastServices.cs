using shop.Core.Dtos;
using System.Net;
using System.Threading.Tasks;

namespace shop.ApplicationServices.Services
{
    public class WeatherForecastServices
    {
        public async Task<WeatherDto>WeatherResponse()
        {
            string idWeather = "UoEbvX4qtjcv0BWpsIRpKpFN2BPf98ML"; //aoikey from accuweather
            var Location = "asd";
            //connection string
            var url = $"http://dataservice.accuweather.com/forecasts/v1/daily/1day/{Location}?apikey={idWeather}";
            //var client1 = new RestClient($"http://dataservice.accuweather.com/forecasts/v1/daily/1day/127964?apikey=UoEbvX4qtjcv0BWpsIRpKpFN2BPf98ML&language=en-us&details=false&metric=true");

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
            }
            return null;
        }
    }
}
