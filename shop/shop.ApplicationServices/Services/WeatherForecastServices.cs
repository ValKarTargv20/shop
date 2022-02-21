using Nancy.Json;
using shop.Core.Dtos;
using shop.Core.Dtos.Weather;
using shop.Core.ServiceInterface;
using System.Net;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using shop.Dtos.Weather;

namespace shop.ApplicationServices.Services
{
    public class WeatherForecastServices : IWeatherForecastServices

    {
        public WeatherResultDto GetResponse(string city)
        {
            throw new System.NotImplementedException();
        }

        public async Task<WeatherResultDto> WeatherDetail(WeatherResultDto dto)
        {
            string apikey = "YjhxFOy76ijmCOWvahkPo2Z9lqpk9ot4"; //APi key
            var url = $"http://dataservice.accuweather.com/forecasts/v1/daily/1day/127964?apikey=YjhxFOy76ijmCOWvahkPo2Z9lqpk9ot4&language=en-us&details=false&metric=true";

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);

                WeatherRootDto weatherInfo = (new JavaScriptSerializer()).Deserialize<WeatherRootDto>(json);

                //Headline
                dto.EffectiveDate = weatherInfo.Headline.EffectiveDate;
                dto.EffectiveEpochDate = weatherInfo.Headline.EffectiveEpochDate;
                dto.Severity = weatherInfo.Headline.Severity;
                dto.Text = weatherInfo.Headline.Text;
                dto.Category = weatherInfo.Headline.Category;
                dto.EndDate = weatherInfo.Headline.EndDate;
                dto.EndEpochDate = weatherInfo.Headline.EndEpochDate;

                dto.MobileLink = weatherInfo.Headline.MobileLink;
                dto.Link = weatherInfo.Headline.Link;
                //DailyForecasts
                //dto.Date = weatherInfo.DailyForecasts.Date;
                //dto.EpochDate = weatherInfo.DailyForecasts.EpochDate;
                //Temperature:
                //Minimum
                //MinimumDto minimumDto = new MinimumDto();
                dto.TempMinValue = weatherInfo.DailyForecasts[0].Temperature.Minimum.Value;
                dto.TempMinUnit = weatherInfo.DailyForecasts[0].Temperature.Minimum.Unit;
                dto.TempMinUnitType = weatherInfo.DailyForecasts[0].Temperature.Minimum.UnitType;
                //Maximum
                //MaximumDto maximumDto = new MaximumDto();
                dto.TempMaxValue = weatherInfo.DailyForecasts[0].Temperature.Maximum.Value;
                dto.TempMaxUnit = weatherInfo.DailyForecasts[0].Temperature.Maximum.Unit;
                dto.TempMaxUnitType = weatherInfo.DailyForecasts[0].Temperature.Maximum.UnitType;
                //Day
                //DayDto dayDto = new DayDto();
                dto.DayIcon = weatherInfo.DailyForecasts[0].Day.Icon;
                dto.DayIconPhrase = weatherInfo.DailyForecasts[0].Day.IconPhrase;
                dto.DayHasPrecipitation = weatherInfo.DailyForecasts[0].Day.HasPrecipitation;
                dto.DayPrecipitationType = weatherInfo.DailyForecasts[0].Day.PrecipitationType;
                dto.DayPrecipitationIntensity = weatherInfo.DailyForecasts[0].Day.PrecipitationIntensity;
                //Night
                //NightDto nightDto = new NightDto();
                dto.NightIcon = weatherInfo.DailyForecasts[0].Night.Icon;
                dto.NightIconPhrase = weatherInfo.DailyForecasts[0].Night.IconPhrase;
                dto.NightHasPrecipitation = weatherInfo.DailyForecasts[0].Night.HasPrecipitation;
                dto.NightPrecipitationType = weatherInfo.DailyForecasts[0].Night.PrecipitationType;
                dto.NightPrecipitationIntensity = weatherInfo.DailyForecasts[0].Night.PrecipitationIntensity;

                var jsonString = new JavaScriptSerializer().Serialize(dto);

                //return jsonString;

            }
            return dto;
        }

    }
}
