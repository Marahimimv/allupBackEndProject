using Microsoft.AspNetCore.Mvc;

namespace allupBackEndProject.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
