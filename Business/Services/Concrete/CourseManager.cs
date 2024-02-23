using Business.DTOs.Course;
using Business.Services.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Services.Concrete
{
	public class CourseManager : ICourseService
	{
		private readonly ICourseDal _courseDal;

		public CourseManager(ICourseDal courseDal)
		{
			_courseDal = courseDal;
		}

		public void Add(CourseAddDto course)
		{
			Course newCourse = new Course();

			newCourse.InstructorId = course.InstructorId;
			newCourse.CategoryId = course.CategoryId;
			newCourse.Name = course.Name;
			newCourse.Description = course.Description;
			newCourse.Price = course.Price;

			_courseDal.Add(newCourse);
		}

		public void Delete(int courseId)
		{
			var deletedCourse = _courseDal.Get(c => c.Id.Equals(courseId));

			_courseDal.Delete(deletedCourse);
		}

		public CourseGetDto Get(int courseId)
		{
			CourseGetDto courseGetDto = new CourseGetDto();

			var hasCourse = _courseDal.Get(c => c.Id.Equals(courseId));

			courseGetDto.Id = hasCourse.Id;
			courseGetDto.InstructorId = hasCourse.InstructorId;
			courseGetDto.CategoryId = hasCourse.CategoryId;
			courseGetDto.Name = hasCourse.Name;
			courseGetDto.Description = hasCourse.Description;
			courseGetDto.Price = hasCourse.Price;

			return courseGetDto;

		}

		public List<CourseGetListDto> GetList()
		{
			var hasCourse = _courseDal.GetList();
			List<CourseGetListDto> courseGetListDtos = new List<CourseGetListDto>();
			foreach (var item in hasCourse)
			{
				CourseGetListDto courseGetListDto = new CourseGetListDto();

				courseGetListDto.Id = item.Id;
				courseGetListDto.InstructorId = item.InstructorId;
				courseGetListDto.CategoryId = item.CategoryId;
				courseGetListDto.Name = item.Name;
				courseGetListDto.Description = item.Description;
				courseGetListDto.Price = item.Price;

				courseGetListDtos.Add(courseGetListDto);
			}

			return courseGetListDtos;
		}

		public void Update(CourseUpdateDto course)
		{
			var hasCourse = _courseDal.Get(c => c.Id.Equals(course.Id));

			hasCourse.InstructorId = course.InstructorId;
			hasCourse.CategoryId = course.CategoryId;
			hasCourse.Name = course.Name;
			hasCourse.Description = course.Description;
			hasCourse.Price = course.Price;

			_courseDal.Update(hasCourse);
		}
	}
}
