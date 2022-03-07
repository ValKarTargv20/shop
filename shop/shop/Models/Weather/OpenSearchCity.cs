using System.ComponentModel.DataAnnotations;

namespace shop.Models.Weather
{
    public class OpenSearchCity
    {
        [Required(ErrorMessage = "You must enter a city name!")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Only text allowed!")]
        [Display(Name = "City Name")]
        public string name { get; set; }
    }
}