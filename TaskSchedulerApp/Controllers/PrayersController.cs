using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskSchedulerApp.Data;
using TaskSchedulerApp.Models;

namespace TaskSchedulerApp.Controllers
{
	public class PrayersController : Controller
	{
		private readonly ApplicationDbContext _context;

		public PrayersController(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			return View(await _context.Prayers.ToListAsync());
		}
	}
}
