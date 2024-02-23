using Core.Entities.Concrete;

namespace Entities.Concrete;

public class Course : BaseEntity<int>
{
	public int InstructorId { get; set; }
	public int CategoryId { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public decimal Price { get; set; }

	public virtual Category Category { get; set; }
	public virtual Instructor Instructor { get; set; }

	public Course() { }
	public Course(int instructorId, int categoryId, string name, string description, decimal price)
	{
		InstructorId = instructorId;
		CategoryId = categoryId;
		Name = name;
		Description = description;
		Price = price;
	}
}
