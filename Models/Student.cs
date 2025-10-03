namespace student_list_backend.Models;

public class Student
{
    public int Id { get; set; }
    public string Address { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Gender Gender { get; set; }
    public List<Grade> Grades { get; set; } = new();
    public string MatriculationNumber { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Program { get; set; } = string.Empty;
    public int Semester { get; set; }
}
