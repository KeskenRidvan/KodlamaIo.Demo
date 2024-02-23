using Business.DTOs.Instructor;
using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class InstructorsController : ControllerBase
	{
		private readonly IInstructorService _instructorService;

		public InstructorsController(IInstructorService instructorService)
		{
			_instructorService = instructorService;
		}

		[HttpGet("getlist")]
		public IActionResult GetList()
		{
			var result = _instructorService.GetList();

			if (result is not null)
			{
				return Ok(result);
			}
			return BadRequest();
		}

		[HttpGet("get")]
		public IActionResult Get(int instructorId)
		{
			var result = _instructorService.Get(instructorId);

			if (result is not null)
			{
				return Ok(result);
			}
			return BadRequest();
		}

		[HttpPost]
		public IActionResult Add(InstructorAddDto instructorAddDto)
		{
			_instructorService.Add(instructorAddDto);
			return Ok();
		}

		[HttpDelete]
		public IActionResult Delete(int instructorId)
		{
			_instructorService.Delete(instructorId);
			return Ok();
		}
		[HttpPut]
		public IActionResult Update(InstructorUpdateDto instructorUpdateDto)
		{
			_instructorService.Update(instructorUpdateDto);
			return Ok();
		}
	}
}
