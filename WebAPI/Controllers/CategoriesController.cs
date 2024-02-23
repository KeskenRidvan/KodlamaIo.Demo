using Business.DTOs.Category;
using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriesController : ControllerBase
	{
		private readonly ICategoryService _categoryService;

		public CategoriesController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		[HttpGet("getlist")]
		public IActionResult GetList()
		{
			var result = _categoryService.GetList();

			if (result is not null)
			{
				return Ok(result);
			}
			return BadRequest();
		}

		[HttpGet("get")]
		public IActionResult Get(int categoryId)
		{
			var result = _categoryService.Get(categoryId);

			if (result is not null)
			{
				return Ok(result);
			}
			return BadRequest();
		}

		[HttpPost]
		public IActionResult Add(CategoryAddDto categoryAddDto)
		{
			_categoryService.Add(categoryAddDto);
			return Ok();
		}

		[HttpDelete]
		public IActionResult Delete(int categoryId)
		{
			_categoryService.Delete(categoryId);
			return Ok();
		}
		[HttpPut]
		public IActionResult Update(CategoryUpdateDto categoryUpdateDto)
		{
			_categoryService.Update(categoryUpdateDto);
			return Ok();
		}
	}
}
