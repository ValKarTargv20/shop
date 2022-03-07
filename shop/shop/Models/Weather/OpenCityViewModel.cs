using Newtonsoft.Json;

namespace shop.Models.Weather
{
    public class OpenCityViewModel
    {
        public string name { get; set; }

        public float temp { get; set; }

        public float feels_like { get; set; }

        public int humidity { get; set; }

        public long pressure { get; set; }

        public float speed { get; set; }

        public string main { get; set; }
    }
}
