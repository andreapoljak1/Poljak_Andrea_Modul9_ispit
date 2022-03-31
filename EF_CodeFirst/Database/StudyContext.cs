using Microsoft.EntityFrameworkCore;
using EF_CodeFirst.Database;
using EF_CodeFirst.Models;
namespace EF_CodeFirst.Database
{
    public class StudyContext : DbContext
    {
        public StudyContext(DbContextOptions<StudyContext> options) : base(options)
        {

        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Grade> Grade { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentID = 1,
                    StudentName = "Petra Ivić",
                    DateOfBirth = new DateTime(1986, 3, 2),
                    Height = 1.60M,
                    Weight = 55F
                },
                new Student
                {
                    StudentID = 2,
                    StudentName = "Ivan Franjić",
                    DateOfBirth = new DateTime(1999, 8, 24),
                    Height = 1.85M,
                    Weight = 85F
                }
            );
            modelBuilder.Entity<Grade>().HasData(
                new Grade
                {
                    GradeId = 1,
                    StudentId = 1,
                    GradeName = "Odličan",
                    Section = "Matematika"
                },
                new Grade
                {
                    GradeId = 2,
                    StudentId = 1,
                    GradeName = "Vrlo dobar",
                    Section = "Povijest"
                },
                new Grade
                {
                    GradeId = 3,
                    StudentId = 1,
                    GradeName = "Odličan",
                    Section = "Fizika"
                },
                new Grade
                {
                    GradeId = 4,
                    StudentId = 2,
                    GradeName = "Dobar",
                    Section = "Matematika"
                },
                new Grade
                {
                    GradeId = 5,
                    StudentId = 2,
                    GradeName = "Vrlo dobar",
                    Section = "Fizika"
                },
                new Grade
                {
                    GradeId = 6,
                    StudentId = 2,
                    GradeName = "Odličan",
                    Section = "Hrvatski"
                },
                new Grade
                {
                    GradeId = 7,
                    StudentId = 2,
                    GradeName = "Odličan",
                    Section = "Kemija"
                }


            );
        }

    }
}
