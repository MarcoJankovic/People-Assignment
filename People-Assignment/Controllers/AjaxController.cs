using Microsoft.AspNetCore.Mvc;

namespace People_Assignment.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
