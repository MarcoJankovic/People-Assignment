using People_Assignment.Models.Data;

namespace People_Assignment.Models.Repos
{
    public interface IPeopleRepo
    {
        public Person Create(string name, string phoneNumber, string cityName);
        public List<Person> Read();
        public Person Read(int personId);
        public bool Update(Person person);
        public bool Delete(Person person);
    }
}
