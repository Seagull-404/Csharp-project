using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public Person GetPerson()
        { 
            return new Person("Seagull", 23);
        }
        [HttpPost]
        public string [] SaveNote(SaveNoteRequest req)
        {
            System.IO.File.WriteAllText(req.Title + ".txt", req.Content);
            return new string[] { "ok", req.Title };
        }
    }
}
