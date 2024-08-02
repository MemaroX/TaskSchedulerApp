using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskSchedulerApp.Data;
using TaskSchedulerApp.Models;

namespace TaskSchedulerApp.Controllers
{
	public class TasksController : Controller
	{
		private readonly ApplicationDbContext _context;

		public TasksController(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			return View(await _context.Tasks.ToListAsync());
		}

		// Other actions (Create, Edit, Delete) would go here
	}
}
