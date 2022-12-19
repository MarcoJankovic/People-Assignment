using People_Assignment.Data;
using People_Assignment.Models.Data;

namespace People_Assignment.Models.Repos
{
    public class DbPeopleRepo : IPeopleRepo
    {

        readonly PeopleDbContext _peopleDbContext;
        public DbPeopleRepo(PeopleDbContext peopleDbContext)
        {
            _peopleDbContext = peopleDbContext;
        }

        public Person Create(string name, string phoneNumber, string cityName)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> Read()
        {
            throw new NotImplementedException();
        }

        public Person Read(int personId)
        {
            throw new NotImplementedException();
        }

        public bool Update(Person person)
        {
            throw new NotImplementedException();
        }
    }

}
