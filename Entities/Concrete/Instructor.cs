using Core.Entities.Concrete;

namespace Entities.Concrete;

public class Instructor : BaseEntity<int>
{
	public int CategoryId { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public DateTime Birthday { get; set; }

	public virtual Category Category { get; set; }
	public virtual ICollection<Course> Courses { get; set; }

	public Instructor()
	{
		Courses = new HashSet<Course>();
	}

	public Instructor(int categoryId, string firstName, string lastName, DateTime birthday)
	{
		CategoryId = categoryId;
		FirstName = firstName;
		LastName = lastName;
		Birthday = birthday;
	}
}
