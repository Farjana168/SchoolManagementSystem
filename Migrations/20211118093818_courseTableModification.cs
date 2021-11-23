using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagementSystem.Migrations
{
    public partial class courseTableModification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "StudentTableStudentId",
                table: "CourseTable");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                    StudentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentPhone = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
    }
}
