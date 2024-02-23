using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
	public void Configure(EntityTypeBuilder<Course> builder)
	{
		builder.ToTable("Courses").HasKey(c => c.Id);

		builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
		builder.Property(c => c.InstructorId).HasColumnName("InstructorId").IsRequired();
		builder.Property(c => c.CategoryId).HasColumnName("CategoryId").IsRequired();
		builder.Property(c => c.Name).HasColumnName("Name").IsRequired();
		builder.Property(c => c.Description).HasColumnName("Description").IsRequired();
		builder.Property(c => c.Price).HasColumnName("Price").IsRequired();

		builder.HasOne(c => c.Instructor);
		builder.HasOne(c => c.Category);
	}
}
