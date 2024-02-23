using Business.Services.Abstract;
using Business.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace Business;

public static class BusinessServiceRegistiration
{
	public static IServiceCollection AddBusinessServices(this IServiceCollection services)
	{
		services.AddScoped<ICategoryService, CategoryManager>();

		//services.AddScoped<ICourseService, CourseManager>();

		services.AddScoped<IInstructorService, InstructorManager>();

		return services;
	}
}
