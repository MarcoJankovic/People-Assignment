﻿using Microsoft.AspNetCore.Mvc;
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
    }
}
