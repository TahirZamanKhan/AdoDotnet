using AdoDotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdoDotnet.Controllers
{
    public class SiteController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>(); 
            return View(students);
        }
    }
}
