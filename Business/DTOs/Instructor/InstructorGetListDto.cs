namespace Business.DTOs.Instructor;

public class InstructorGetListDto
{
	public int Id { get; set; }
	public int CategoryId { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public DateTime Birthday { get; set; }
}
