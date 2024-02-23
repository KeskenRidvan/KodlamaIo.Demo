using Business.DTOs.Course;
using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CoursesController : ControllerBase
	{
		private readonly ICourseService _courseService;

		public CoursesController(ICourseService courseService)
		{
			_courseService = courseService;
		}

		[HttpGet("getlist")]
		public IActionResult GetList()
		{
			var result = _courseService.GetList();

			if (result is not null)
			{
				return Ok(result);
			}
			return BadRequest();
		}

		[HttpGet("get")]
		public IActionResult Get(int courseId)
		{
			var result = _courseService.Get(courseId);

			if (result is not null)
			{
				return Ok(result);
			}
			return BadRequest();
		}

		[HttpPost]
		public IActionResult Add(CourseAddDto courseAddDto)
		{
			_courseService.Add(courseAddDto);
			return Ok();
		}

		[HttpDelete]
		public IActionResult Delete(int courseId)
		{
			_courseService.Delete(courseId);
			return Ok();
		}
		[HttpPut]
		public IActionResult Update(CourseUpdateDto courseUpdateDto)
		{
			_courseService.Update(courseUpdateDto);
			return Ok();
		}
	}
}
