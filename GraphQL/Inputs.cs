using student_list_backend.Models;
namespace student_list_backend.GraphQL;

public record GradeInput(string CourseName, string GradeValue, string Date, bool IsPassed);

public record StudentInput(
    string Address,
    string Email,
    Gender Gender,
    string MatriculationNumber,
    string Name,
    string Program,
    int Semester,
    List<GradeInput> Grades
);
