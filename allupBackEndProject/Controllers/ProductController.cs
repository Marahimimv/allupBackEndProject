using Microsoft.AspNetCore.Mvc;

namespace allupBackEndProject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
