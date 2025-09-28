namespace student_list_backend.Models;

public class Grade
{
    public int Id { get; set; }
    public string CourseName { get; set; }      // courseName
    public string Date { get; set; }            // date
    public string GradeValue { get; set; }      // grade
    public bool IsPassed { get; set; }          // isPassed
    public int StudentId { get; set; }
    public Student Student { get; set; }
}