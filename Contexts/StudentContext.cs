using Microsoft.EntityFrameworkCore;
using student_list_backend.Models;

namespace student_list_backend.Contexts;

public class StudentContext : DbContext
{
    public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Grade> Grades { get; set; } = null!;
}