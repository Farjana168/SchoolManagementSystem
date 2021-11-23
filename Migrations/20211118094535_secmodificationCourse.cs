using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagementSystem.Migrations
{
    public partial class secmodificationCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "CourseTable");

            migrationBuilder.AddColumn<int>(
                name: "StudentId1",
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
                name: "IX_CourseTable_StudentId1",
                table: "CourseTable",
                column: "StudentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTable_StudentTable_StudentId1",
                table: "CourseTable",
                column: "StudentId1",
                principalTable: "StudentTable",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseTable_StudentTable_StudentId1",
                table: "CourseTable");

            migrationBuilder.DropTable(
                name: "StudentTable");

            migrationBuilder.DropIndex(
                name: "IX_CourseTable_StudentId1",
                table: "CourseTable");

            migrationBuilder.DropColumn(
                name: "StudentId1",
                table: "CourseTable");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "CourseTable",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
