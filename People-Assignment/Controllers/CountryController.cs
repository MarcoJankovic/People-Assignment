using Microsoft.AspNetCore.Mvc;

namespace People_Assignment.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
