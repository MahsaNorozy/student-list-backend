using HotChocolate;                   
using Microsoft.EntityFrameworkCore;
using student_list_backend.Contexts;
using student_list_backend.Models;

namespace student_list_backend.GraphQL;

public class Mutation
{
    public async Task<Student> AddStudent([Service] StudentContext ctx, StudentInput input)
    {
        var s = new Student
        {
            Address = input.Address,
            Email = input.Email,
            Gender = input.Gender,
            MatriculationNumber = input.MatriculationNumber,
            Name = input.Name,
            Program = input.Program,
            Semester = input.Semester,
            Grades = input.Grades.Select(g => new Grade
            {
                CourseName = g.CourseName,
                GradeValue = g.GradeValue,
                Date = g.Date,       
                IsPassed = g.IsPassed
            }).ToList()
        };

        ctx.Students.Add(s);
        await ctx.SaveChangesAsync();
        return s;
    }

    public async Task<Student?> UpdateStudent([Service] StudentContext ctx, int id, StudentInput input)
    {
        var s = await ctx.Students.Include(x => x.Grades).FirstOrDefaultAsync(x => x.Id == id);
        if (s is null) return null;

        s.Address = input.Address;
        s.Email = input.Email;
        s.Gender = input.Gender;
        s.MatriculationNumber = input.MatriculationNumber;
        s.Name = input.Name;
        s.Program = input.Program;
        s.Semester = input.Semester;

        ctx.Grades.RemoveRange(s.Grades);
        await ctx.SaveChangesAsync(); 

        var newGrades = input.Grades.Select(g => new Grade
        {
            CourseName = g.CourseName,
            GradeValue = g.GradeValue,
            Date = g.Date,
            IsPassed = g.IsPassed,
            StudentId = s.Id
        }).ToList();

        s.Grades = newGrades;
        await ctx.SaveChangesAsync();

        return s;
    }

}

