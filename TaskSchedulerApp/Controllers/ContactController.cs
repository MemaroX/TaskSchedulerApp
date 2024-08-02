using Microsoft.AspNetCore.Mvc;

namespace TaskSchedulerApp
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

