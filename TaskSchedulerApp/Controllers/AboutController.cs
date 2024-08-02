using Microsoft.AspNetCore.Mvc;
namespace TaskSchedulerApp
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

