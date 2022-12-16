using Microsoft.AspNetCore.Mvc;

namespace People_Assignment.Controllers
{
    public class LanguageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
