using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace People_Assignment.Models.ViewModels
{
    public class CreatePersonViewModel
    {
        [DisplayAttribute(Name = "Name")]
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [DisplayAttribute(Name = "PhoneNumber")]
        [Required]
        [StringLength(10)]
        public string? PhoneNumber { get; set; }

        [DisplayAttribute(Name = "CityName")]
        [Required]
        public string? CityName { get; set; }

        [Required]
        public List<string> CityList
        {
            get
            {
                return new List<string>
                {   "Stockholm",
                    "Göteborg",
                    "Malmö",
                    "Växjö",
                    "Karlskrona",
                    "Värnamo",
                    "London",
                    "Oslo",
                    "Copenhagen",
                    "Moscow",
                    "Paris",
                    "Berlin",
                    "Madrid",
                    "Warsaw",
                    "Helsinki",
                    "Tokyo",
                    "Beijing"
                };
            }
        }

    }
}
