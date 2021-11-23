using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagementSystem.Migrations
{
    public partial class totalModification1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseTable_StudentTable_StudentId1",
                table: "CourseTable");

            migrationBuilder.DropIndex(
                name: "IX_CourseTable_StudentId1",
                table: "CourseTable");

            migrationBuilder.DropColumn(
                name: "StudentId1",
                table: "CourseTable");

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
                name: "TeacherTable",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherDOB = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherTable", x => x.TeacherId);
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

            migrationBuilder.CreateTable(
                name: "TeacherCourseStudent",
                columns: table => new
                {
                    TeacherCourseStudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherCourseStudentSection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherCourseStudent", x => x.TeacherCourseStudentId);
                    table.ForeignKey(
                        name: "FK_TeacherCourseStudent_CourseTable_CourseId",
                        column: x => x.CourseId,
                        principalTable: "CourseTable",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherCourseStudent_StudentTable_StudentId",
                        column: x => x.StudentId,
                        principalTable: "StudentTable",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherCourseStudent_TeacherTable_TeacherId",
                        column: x => x.TeacherId,
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

            migrationBuilder.CreateIndex(
                name: "IX_TeacherCourseStudent_CourseId",
                table: "TeacherCourseStudent",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherCourseStudent_StudentId",
                table: "TeacherCourseStudent",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherCourseStudent_TeacherId",
                table: "TeacherCourseStudent",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseTableStudentTable");

            migrationBuilder.DropTable(
                name: "CourseTableTeacherTable");

            migrationBuilder.DropTable(
                name: "StudentTableTeacherTable");

            migrationBuilder.DropTable(
                name: "TeacherCourseStudent");

            migrationBuilder.DropTable(
                name: "TeacherTable");

            migrationBuilder.AddColumn<int>(
                name: "StudentId1",
                table: "CourseTable",
                type: "int",
                nullable: true);

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
    }
}
