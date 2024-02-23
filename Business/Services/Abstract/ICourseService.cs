using Business.DTOs.Course;

namespace Business.Services.Abstract
{
	public interface ICourseService
	{
		CourseGetDto Get(int courseId);
		List<CourseGetListDto> GetList();
		void Add(CourseAddDto course);
		void Update(CourseUpdateDto course);
		void Delete(int courseId);
	}
}
