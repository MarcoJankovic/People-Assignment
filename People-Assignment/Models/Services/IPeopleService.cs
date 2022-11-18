using People_Assignment.Models.Data;
using People_Assignment.Models.ViewModels;

namespace People_Assignment.Models.Services
{

    public interface IPeopleService
    {
        Person Create(CreatePersonViewModel createPeople);

        List<Person> GetAll();

        List<Person> FindByCity(string city);

        Person FindById(int id);

        public void Edit(int id, CreatePersonViewModel editPeople)
        {

        }
        public bool Remove(int id);

        Person LastAdded();
    }

}
