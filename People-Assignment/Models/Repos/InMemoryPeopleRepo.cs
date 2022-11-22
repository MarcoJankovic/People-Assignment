using People_Assignment.Models.Data;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace People_Assignment.Models.Repos
{
    public class InMemoryPeopleRepo : IPeopleRepo

    {
        private static List<Person> peopleList = new List<Person>();
        private static int idCounter = 0;

        public Person Create(string name, string phoneNumber, string cityName)
        {
            Person person = new Person(name, phoneNumber, cityName);

            person.PersonId = ++idCounter;
            person.Name = name;
            person.PhoneNumber = phoneNumber;
            person.CityName = cityName;
            peopleList.Add(person);
            return person;
        }
        public List<Person> Read()
        {
            return peopleList;
        }

        public Person Read(int personId)
        {
            foreach (Person person in peopleList)
            {
                if (person.PersonId == personId)
                {
                    return person;
                }
            }
            return null;
        }

        public bool Update(Person person)
        {
            Person original = Read(person.PersonId);
            if(original == null)
            {
                return false;
            }
            else
            {
                original.Name= person.Name;
                original.PhoneNumber= person.PhoneNumber;
                original.CityName= person.CityName;
                return true;
            }

        }
        public bool Delete(Person person)
        {
            return peopleList.Remove(person);
        }
    }
}

