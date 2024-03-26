using Microsoft.AspNetCore.Mvc;

namespace EvoApp.Controllers
{
    public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Menu()
		{
			return PartialView();
		}
	}
}
