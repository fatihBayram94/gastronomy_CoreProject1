using Microsoft.AspNetCore.Mvc;

namespace gastronomy_CoreProject.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
