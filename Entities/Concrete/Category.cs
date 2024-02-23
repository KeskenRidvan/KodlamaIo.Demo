using Core.Entities.Concrete;

namespace Entities.Concrete;

public class Category : BaseEntity<int>
{
	public string Name { get; set; }

	public virtual ICollection<Course> Courses { get; set; }
	public virtual ICollection<Instructor> Instructors { get; set; }

	public Category(string name)
	{
		Name = name;
	}

	public Category()
	{
		Courses = new HashSet<Course>();
		Instructors = new HashSet<Instructor>();
	}
}
