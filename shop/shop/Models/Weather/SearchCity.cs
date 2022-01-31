using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Models.Weather
{
    public class SearchCity
    { 
        [Required(ErrorMessage = "Enter City name!")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage ="Only text allowed!")]
        [Display(Name = "City Name")]
        public string CityName { get; set; }
    }
}
