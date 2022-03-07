using Newtonsoft.Json;

namespace shop.Core.Dtos.Weather
{
    public class sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public float message { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }

    }
}