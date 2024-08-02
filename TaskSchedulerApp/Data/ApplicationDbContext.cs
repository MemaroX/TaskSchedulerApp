using Microsoft.EntityFrameworkCore;
using TaskSchedulerApp.Models;

namespace TaskSchedulerApp.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Task1> Tasks { get; set; }
        public DbSet<Prayer> Prayers { get; set; }
    }
}
