using Microsoft.EntityFrameworkCore;
using People_Assignment.Models.Data;

namespace People_Assignment.Data
{
    public class PeopleDbContext : DbContext
    {
        public PeopleDbContext(DbContextOptions<PeopleDbContext> options) : base(options) 
        { }

        public DbSet<Person>? Persons { get; set; }
    }
}
