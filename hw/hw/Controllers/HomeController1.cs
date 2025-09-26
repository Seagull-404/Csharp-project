using Microsoft.AspNetCore.Mvc;

namespace hw.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
