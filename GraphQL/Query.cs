using HotChocolate;                   
using Microsoft.EntityFrameworkCore;
using student_list_backend.Contexts;
using student_list_backend.Models;

namespace student_list_backend.GraphQL;

public class Query
{
    public IQueryable<Student> GetStudents([Service] StudentContext ctx) => ctx.Students.Include(s => s.Grades);

    public Task<Student?> GetStudent(int id, [Service] StudentContext ctx) =>
        ctx.Students.Include(s => s.Grades).FirstOrDefaultAsync(s => s.Id == id);
}