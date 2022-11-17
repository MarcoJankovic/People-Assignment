using Microsoft.AspNetCore.Mvc;

namespace People_Assignment.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
