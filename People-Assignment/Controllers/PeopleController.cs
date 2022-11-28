using Microsoft.AspNetCore.Mvc;
using People_Assignment.Models.Repos;
using People_Assignment.Models.Data;
using People_Assignment.Models.Services;
using People_Assignment.Models.ViewModels;
using System.Security.Cryptography;

namespace People_Assignment.Controllers
{
    public class PeopleController : Controller
    {
        IPeopleService _peopleService;
        public PeopleController()
        {
            _peopleService = new PeopleService(new InMemoryPeopleRepo());
        }
        public IActionResult Person()
        {
            return View(_peopleService.All());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreatePersonViewModel());
        }

        [HttpPost]

        public IActionResult Create(CreatePersonViewModel createPeople)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _peopleService.Add(createPeople);
                }
                catch (ArgumentException ex)
                {
                    // Add our own message
                    ModelState.AddModelError("Name", ex.Message);
                    return View(createPeople);
                }
                return RedirectToAction(nameof(Person));
            }
            return View(createPeople);
        }

        public IActionResult Details(int id)
        {
            Person person = _peopleService.FindById(id);
            if (person == null)
            {
                return RedirectToAction(nameof(Person));
            }
            return View(person);          
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Person person = _peopleService.FindById(id);

            if (person == null)
            {
                return RedirectToAction(nameof(Person));
            }
            CreatePersonViewModel editPerson = new CreatePersonViewModel()
            {
                Name = person.Name,
                PhoneNumber = person.PhoneNumber,
                CityName = person.CityName,
            };

            return View(editPerson);
        }

        [HttpPost]
        public IActionResult Edit(int id, CreatePersonViewModel editPerson)
        {
            if (ModelState.IsValid)
            {
                _peopleService.Edit(id, editPerson);
                return RedirectToAction(nameof(Person));
            }
            _peopleService.Add(editPerson);
            return View(editPerson);
        }
        public IActionResult Delete(int id)
        {
            _peopleService.Remove(id);
            return RedirectToAction(nameof(Person));
        }
    }
}
