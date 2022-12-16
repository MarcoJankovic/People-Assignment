using System.ComponentModel.DataAnnotations;

namespace People_Assignment.Models.Data
{
    public class Country
    {

        [Key]
        public int Id { get; set; }
        public string? CountryName { get; set; }
    }
}
