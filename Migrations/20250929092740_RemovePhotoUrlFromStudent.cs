using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace student_list_backend.Migrations
{
    /// <inheritdoc />
    public partial class RemovePhotoUrlFromStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Students",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Students",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "Students",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
