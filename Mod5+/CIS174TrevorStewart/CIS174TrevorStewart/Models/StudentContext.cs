using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CIS174TrevorStewart.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        { }

        public DbSet<Student> Students { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        { 
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(

                new Student
                {
                    StudentId = 1,
                    FirstName = "Trevor",
                    LastName = "Stewart",
                    Grade = "A"
                },
                new Student
                {
                    StudentId = 2,
                    FirstName = "Amber",
                    LastName = "Lang",
                    Grade = "A"
                },
                new Student
                {
                    StudentId = 3,
                    FirstName = "Steve",
                    LastName = "Bobber",
                    Grade = "B"
                },
                new Student
                {
                    StudentId = 4,
                    FirstName = "Chuck",
                    LastName = "Tingle",
                    Grade = "A-"
                },
                new Student
                {
                    StudentId = 5,
                    FirstName = "Cody",
                    LastName = "Phish",
                    Grade = "C"
                }
                );
        }
    }
}
