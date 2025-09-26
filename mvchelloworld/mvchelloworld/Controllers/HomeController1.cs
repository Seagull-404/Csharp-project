using Microsoft.AspNetCore.Mvc;

namespace mvchelloworld.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
