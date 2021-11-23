using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagementSystem.Migrations
{
    public partial class addStudentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "CourseTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentTableStudentId",
                table: "CourseTable",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StudentTable",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTable", x => x.StudentId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseTable_StudentTableStudentId",
                table: "CourseTable",
                column: "StudentTableStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTable_StudentTable_StudentTableStudentId",
                table: "CourseTable",
                column: "StudentTableStudentId",
                principalTable: "StudentTable",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseTable_StudentTable_StudentTableStudentId",
                table: "CourseTable");

            migrationBuilder.DropTable(
                name: "StudentTable");

            migrationBuilder.DropIndex(
                name: "IX_CourseTable_StudentTableStudentId",
                table: "CourseTable");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "CourseTable");

            migrationBuilder.DropColumn(
                name: "StudentTableStudentId",
                table: "CourseTable");
        }
    }
}
