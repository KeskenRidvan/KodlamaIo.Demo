using Business.DTOs.Instructor;
using Business.Services.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Services.Concrete;

public class InstructorManager : IInstructorService
{
	private readonly IInstructorDal _instructorDal;
	public InstructorManager(IInstructorDal instructorDal)
	{
		_instructorDal = instructorDal;
	}

	public void Add(InstructorAddDto instructor)
	{
		Instructor newInstructor = new Instructor();

		newInstructor.CategoryId = instructor.CategoryId;
		newInstructor.FirstName = instructor.FirstName;
		newInstructor.LastName = instructor.LastName;
		newInstructor.Birthday = instructor.Birthday;

		_instructorDal.Add(newInstructor);
	}

	public void Delete(int instructorId)
	{
		var deletedInstructor = _instructorDal.Get(i => i.Id.Equals(instructorId));

		_instructorDal.Delete(deletedInstructor);
	}

	public InstructorGetDto Get(int instructorId)
	{
		InstructorGetDto instructorGetDto = new InstructorGetDto();
		var hasInstructor = _instructorDal.Get(i => i.Id.Equals(instructorId));

		instructorGetDto.Id = hasInstructor.Id;
		instructorGetDto.CategoryId = hasInstructor.CategoryId;
		instructorGetDto.FirstName = hasInstructor.FirstName;
		instructorGetDto.LastName = hasInstructor.LastName;
		instructorGetDto.Birthday = hasInstructor.Birthday;

		return instructorGetDto;
	}

	public List<InstructorGetListDto> GetList()
	{
		var hasInstructor = _instructorDal.GetList();

		List<InstructorGetListDto> instructorGetListDtos = new List<InstructorGetListDto>();

		foreach (var item in hasInstructor)
		{
			InstructorGetListDto instructorGetListDto = new InstructorGetListDto();

			instructorGetListDto.Id = item.Id;
			instructorGetListDto.CategoryId = item.CategoryId;
			instructorGetListDto.FirstName = item.FirstName;
			instructorGetListDto.LastName = item.LastName;
			instructorGetListDto.Birthday = item.Birthday;

			instructorGetListDtos.Add(instructorGetListDto);
		}
		return instructorGetListDtos;
	}

	public void Update(InstructorUpdateDto instructor)
	{
		var hasInstructor = _instructorDal.Get(c => c.Id.Equals(instructor.Id));

		hasInstructor.CategoryId = instructor.CategoryId;
		hasInstructor.FirstName = instructor.FirstName;
		hasInstructor.LastName = instructor.LastName;
		hasInstructor.Birthday = instructor.Birthday;

		_instructorDal.Update(hasInstructor);
	}
}
