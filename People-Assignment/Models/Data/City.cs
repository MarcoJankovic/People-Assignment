using System.ComponentModel.DataAnnotations;

namespace People_Assignment.Models.Data
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string? CityName { get; set; }

    }
}
