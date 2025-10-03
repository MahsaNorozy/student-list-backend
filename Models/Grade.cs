namespace student_list_backend.Models;

public class Grade
{
    public int Id { get; set; }
    public string CourseName { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
    public string GradeValue { get; set; } = string.Empty;
    public bool IsPassed { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;
}
