namespace student_list_backend.Models;

public class Student
{
    public int Id { get; set; }                 // id
    public string Address { get; set; }         // address
    public string Email { get; set; }           // email
    public string Gender { get; set; }          // gender
    public List<Grade> Grades { get; set; }     // grades
    public string MatriculationNumber { get; set; } // matriculationNumber
    public string Name { get; set; }            // name
    public string PhotoUrl { get; set; }        // photoUrl
    public string Program { get; set; }         // program
    public int Semester { get; set; }           // semester
}