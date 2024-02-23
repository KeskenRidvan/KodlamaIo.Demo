namespace Business.DTOs.Course;

public class CourseGetDto
{
	public int Id { get; set; }
	public int InstructorId { get; set; }
	public int CategoryId { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public decimal Price { get; set; }
}



