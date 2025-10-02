using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace student_list_backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "Email", "Gender", "MatriculationNumber", "Name", "Program", "Semester" },
                values: new object[,]
                {
                    { 1, "Musterstraße 1, 12345 Berlin", "anna@beispiel.de", 1, "1234567", "Anna Schmidt", "Informatik", 2 },
                    { 2, "Beispielweg 2, 54321 Hamburg", "max@beispiel.de", 2, "2345678", "Max Müller", "Maschinenbau", 3 }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseName", "Date", "GradeValue", "IsPassed", "StudentId" },
                values: new object[,]
                {
                    { 1, "Mathe 1", "2024-02-10", "1.3", true, 1 },
                    { 2, "Programmierung", "2024-02-15", "2.0", true, 1 },
                    { 3, "Mechanik", "2024-03-12", "2.3", true, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
