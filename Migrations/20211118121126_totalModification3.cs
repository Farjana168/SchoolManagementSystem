using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagementSystem.Migrations
{
    public partial class totalModification3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseTableStudentTable");

            migrationBuilder.DropTable(
                name: "CourseTableTeacherTable");

            migrationBuilder.DropTable(
                name: "StudentTableTeacherTable");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseTableStudentTable",
                columns: table => new
                {
                    CoursesCourseId = table.Column<int>(type: "int", nullable: false),
                    StudentsStudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTableStudentTable", x => new { x.CoursesCourseId, x.StudentsStudentId });
                    table.ForeignKey(
                        name: "FK_CourseTableStudentTable_CourseTable_CoursesCourseId",
                        column: x => x.CoursesCourseId,
                        principalTable: "CourseTable",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseTableStudentTable_StudentTable_StudentsStudentId",
                        column: x => x.StudentsStudentId,
                        principalTable: "StudentTable",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseTableTeacherTable",
                columns: table => new
                {
                    CoursesCourseId = table.Column<int>(type: "int", nullable: false),
                    TeachersTeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTableTeacherTable", x => new { x.CoursesCourseId, x.TeachersTeacherId });
                    table.ForeignKey(
                        name: "FK_CourseTableTeacherTable_CourseTable_CoursesCourseId",
                        column: x => x.CoursesCourseId,
                        principalTable: "CourseTable",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseTableTeacherTable_TeacherTable_TeachersTeacherId",
                        column: x => x.TeachersTeacherId,
                        principalTable: "TeacherTable",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentTableTeacherTable",
                columns: table => new
                {
                    StudentsStudentId = table.Column<int>(type: "int", nullable: false),
                    TeachersTeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTableTeacherTable", x => new { x.StudentsStudentId, x.TeachersTeacherId });
                    table.ForeignKey(
                        name: "FK_StudentTableTeacherTable_StudentTable_StudentsStudentId",
                        column: x => x.StudentsStudentId,
                        principalTable: "StudentTable",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentTableTeacherTable_TeacherTable_TeachersTeacherId",
                        column: x => x.TeachersTeacherId,
                        principalTable: "TeacherTable",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseTableStudentTable_StudentsStudentId",
                table: "CourseTableStudentTable",
                column: "StudentsStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTableTeacherTable_TeachersTeacherId",
                table: "CourseTableTeacherTable",
                column: "TeachersTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTableTeacherTable_TeachersTeacherId",
                table: "StudentTableTeacherTable",
                column: "TeachersTeacherId");
        }
    }
}
