using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions options) : base(options)
	{
	}

	public AppDbContext() { }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite(@"Data source=KodlamaIO.db");
	}

	public DbSet<Category> Categories { get; set; }
	public DbSet<Course> Courses { get; set; }
	public DbSet<Instructor> Instructors { get; set; }

}
