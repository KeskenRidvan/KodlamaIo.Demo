using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;

public static class DataAccessServiceRegistiration
{
	public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
	{

		services.AddDbContext<AppDbContext>(options =>
		{
			options.UseSqlite(configuration.GetConnectionString("SqlCon"));
		});

		services.AddScoped<ICategoryDal, CategoryDal>();
		services.AddScoped<ICourseDal, CourseDal>();
		services.AddScoped<IInstructorDal, InstructorDal>();

		return services;
	}
}
