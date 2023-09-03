using Microsoft.AspNetCore.Mvc;

namespace allupBackEndProject.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
