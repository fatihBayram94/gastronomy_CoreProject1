using Microsoft.AspNetCore.Mvc;

namespace gastronomy_CoreProject.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
