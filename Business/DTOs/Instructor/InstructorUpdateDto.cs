namespace Business.DTOs.Instructor;

public class InstructorUpdateDto
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public DateTime Birthday { get; set; }
}
