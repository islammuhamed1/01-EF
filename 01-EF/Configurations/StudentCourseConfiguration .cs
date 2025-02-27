using _01_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace _01_EF.Configurations
{
    class StudentCourseConfiguration : IEntityTypeConfiguration<Entities.InstructorCourseConfiguration>
    {
        public void Configure(EntityTypeBuilder<Entities.InstructorCourseConfiguration> builder)
        {
            builder.Property(x => x.Grade)
                   .HasMaxLength(3);
        }
    }

}
