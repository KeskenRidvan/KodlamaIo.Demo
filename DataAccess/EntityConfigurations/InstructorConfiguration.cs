using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
{
	public void Configure(EntityTypeBuilder<Instructor> builder)
	{
		builder.ToTable("Instructors").HasKey(c => c.Id);

		builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
		builder.Property(i => i.CategoryId).HasColumnName("CategoryId").IsRequired();
		builder.Property(i => i.FirstName).HasColumnName("FirtName").IsRequired();
		builder.Property(i => i.LastName).HasColumnName("LastName").IsRequired();
		builder.Property(i => i.Birthday).HasColumnName("Birthday").IsRequired();

		builder.HasOne(i => i.Category);
		builder.HasMany(i => i.Courses);
	}
}
