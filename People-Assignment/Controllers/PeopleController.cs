using Microsoft.AspNetCore.Mvc;

namespace People_Assignment.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Person()
        {
            return View();
        }


        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
