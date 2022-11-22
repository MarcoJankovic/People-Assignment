using People_Assignment.Models.Data;
using People_Assignment.Models.ViewModels;

namespace People_Assignment.Models.Services
{

    public interface IPeopleService
    {
        Person Add(CreatePersonViewModel person);

        List<Person> All();
        List<Person> Search(string search);
        Person FindById(int personId);

        public bool Edit(int personId, CreatePersonViewModel editPeople)
        public bool Remove(int personId);

    }

}
