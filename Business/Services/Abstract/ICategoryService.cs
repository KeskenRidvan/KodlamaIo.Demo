using Business.DTOs.Category;

namespace Business.Services.Abstract;

public interface ICategoryService
{
	CategoryGetDto Get(int categoryId);
	List<CategoryGetListDto> GetList();
	void Add(CategoryAddDto category);
	void Update(CategoryUpdateDto category);
	void Delete(int categoryId);
}
