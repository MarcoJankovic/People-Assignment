using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
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

            if (string.IsNullOrWhiteSpace(createPerson.Name) || string.IsNullOrWhiteSpace(createPerson.PhoneNumber) || string.IsNullOrWhiteSpace(createPerson.CityName))
            {
                throw new ArgumentException("Name,PhoneNumber or City, not be consist of backspace(s)/whitespace(s)");
            }

            return person;
        }

        public List<Person> All()
        {
            return _peopleRepo.Read();
        }

        public bool Edit(int personId, CreatePersonViewModel editPerson)
        {
            Person originalPerson = FindById(personId);
            if (originalPerson != null)
            {
                originalPerson.Name = editPerson.Name;
                originalPerson.PhoneNumber = editPerson.PhoneNumber;
                originalPerson.CityName = editPerson.CityName;
            }
            return _peopleRepo.Update(originalPerson);
        }

        public Person FindById(int personId)
        {
            Person trackPerson = _peopleRepo.Read(personId);

            return trackPerson;
        }

        public List<Person> Search(string search)
        {
            List<Person> searchPerson = _peopleRepo.Read();

            foreach (Person x in _peopleRepo.Read())
            {
                if (x.Name.Contains(search, StringComparison.OrdinalIgnoreCase))
                {
                    searchPerson = searchPerson.Where(p => p.Name.ToUpper().Contains(search.ToUpper())).ToList();
                    searchPerson.Add(x);
                }
            }
            if (searchPerson.Count == 0)
            {
                throw new ArgumentException("Could not find what you where looking for");
            }
            return searchPerson;
        }

        public bool Remove(int personId)
        {
            Person person = _peopleRepo.Read(personId);

            return _peopleRepo.Delete(person);
        }
    }
}
