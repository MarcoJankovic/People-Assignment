using System.ComponentModel.DataAnnotations;

namespace People_Assignment.Models.ViewModels
{
    public class CreatePersonViewModel
    {
        [Display(Name = "Name")]
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Display(Name = "PhoneNumber")]
        [Required]
        [StringLength(10)]
        public string? PhoneNumber { get; set; }

        [Display(Name = "CityName")]
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
