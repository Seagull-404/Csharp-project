using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Demo1()
        {
           // return View();
           Person p1 = new Person("Seagull_404", true, DateTime.Now);
              return View(p1);
        }
    }
}
