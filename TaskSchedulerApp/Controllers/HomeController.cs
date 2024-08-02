using Microsoft.AspNetCore.Mvc;

namespace TaskSchedulerApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
