using Business.DTOs.Category;
using Business.Services.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Services.Concrete;

public class CategoryManager : ICategoryService
{
	private readonly ICategoryDal _categoryDal;
	public CategoryManager(ICategoryDal categoryDal)
	{
		_categoryDal = categoryDal;
	}

	public void Add(CategoryAddDto category)
	{
		Category newCategory = new Category();
		newCategory.Name = category.Name;

		_categoryDal.Add(newCategory);
	}

	public void Delete(int categoryId)
	{
		var deletedCategory = _categoryDal.Get(c => c.Id.Equals(categoryId));

		_categoryDal.Delete(deletedCategory);
	}

	public CategoryGetDto Get(int categoryId)
	{
		CategoryGetDto categoryGetDto = new CategoryGetDto();

		var hasCategory = _categoryDal.Get(c => c.Id.Equals(categoryId));
		categoryGetDto.Name = hasCategory.Name;

		return categoryGetDto;
	}

	public List<CategoryGetListDto> GetList()
	{
		var hasCategory = _categoryDal.GetList();

		List<CategoryGetListDto> categoryGetListDtos = new List<CategoryGetListDto>();

		foreach (var item in hasCategory)
		{
			CategoryGetListDto categoryGetListDto = new CategoryGetListDto();

			categoryGetListDto.Id = item.Id;
			categoryGetListDto.Name = item.Name;

			categoryGetListDtos.Add(categoryGetListDto);
		}

		return categoryGetListDtos;
	}

	public void Update(CategoryUpdateDto category)
	{
		var hasCategory = _categoryDal.Get(c => c.Id.Equals(category.Id));
		hasCategory.Name = category.Name;

		_categoryDal.Update(hasCategory);
	}
}
