using People_Assignment.Models.Data;

namespace People_Assignment.Models.Repos
{
    public interface IPeopleRepo
    {
        public Person Create(Person person);
        public List<Person> Read();
        public Person Read(int personId);
        public bool Update(Person person);
        public bool Delete(Person person);
    }
}
