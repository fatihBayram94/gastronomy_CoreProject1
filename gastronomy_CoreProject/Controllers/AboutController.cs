using Microsoft.AspNetCore.Mvc;

namespace gastronomy_CoreProject.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
