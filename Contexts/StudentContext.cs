using Microsoft.EntityFrameworkCore;
using student_list_backend.Models;

namespace student_list_backend.Contexts;

public class StudentContext : DbContext
{
    public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Grade> Grades { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Beispiel-Studenten
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    Name = "Anna Schmidt",
                    MatriculationNumber = "1234567",
                    Email = "anna@beispiel.de",
                    Address = "Musterstraße 1, 12345 Berlin",
                    Program = "Informatik",
                    Semester = 2,
                    Gender = Gender.Female
                },
                new Student
                {
                    Id = 2,
                    Name = "Max Müller",
                    MatriculationNumber = "2345678",
                    Email = "max@beispiel.de",
                    Address = "Beispielweg 2, 54321 Hamburg",
                    Program = "Maschinenbau",
                    Semester = 3,
                    Gender = Gender.Male
                }
            );

            // Beispiel-Noten
            modelBuilder.Entity<Grade>().HasData(
                new Grade
                {
                    Id = 1,
                    CourseName = "Mathe 1",
                    Date = "2024-02-10",
                    GradeValue = "1.3",
                    IsPassed = true,
                    StudentId = 1
                },
                new Grade
                {
                    Id = 2,
                    CourseName = "Programmierung",
                    Date = "2024-02-15",
                    GradeValue = "2.0",
                    IsPassed = true,
                    StudentId = 1
                },
                new Grade
                {
                    Id = 3,
                    CourseName = "Mechanik",
                    Date = "2024-03-12",
                    GradeValue = "2.3",
                    IsPassed = true,
                    StudentId = 2
                }
            );
        }
}
