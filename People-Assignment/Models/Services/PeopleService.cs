using People_Assignment.Models.Data;
using People_Assignment.Models.Repos;
using People_Assignment.Models.ViewModels;

namespace People_Assignment.Models.Services
{
    public class PeopleService : IPeopleService
    {
        IPeopleRepo _peopleRepo { get; set; }
        public PeopleService(IPeopleRepo peopleRepo)
        {
            _peopleRepo = peopleRepo;
        }

        public Person Add(CreatePersonViewModel createPerson)
        {
            Person person = _peopleRepo.Create(createPerson.Name, createPerson.PhoneNumber, createPerson.CityName);
            if (string.IsNullOrWhiteSpace(createPerson.Name)
                || string.IsNullOrWhiteSpace(createPerson.PhoneNumber)
                || string.IsNullOrWhiteSpace(createPerson.CityName))
            {
                throw new ArgumentException("Name,PhoneNumber or City, not be consist of backspace(s)/whitespace(s)");
            }
            return person;
        }

        public List<Person> All()
        {
            return _peopleRepo.Read();
        }

        public bool Edit(int personId, CreatePersonViewModel editPeople)
        {
            
        }

        public Person FindById(int personId)
        {
            
        }

        public List<Person> Search(string search)
        {
            
        }
        public bool Remove(int personId)
        {
            
        }


    }
}
