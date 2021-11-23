using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagementSystem.Migrations
{
    public partial class totalModification2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherCourseStudent_CourseTable_CourseId",
                table: "TeacherCourseStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherCourseStudent_StudentTable_StudentId",
                table: "TeacherCourseStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherCourseStudent_TeacherTable_TeacherId",
                table: "TeacherCourseStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherCourseStudent",
                table: "TeacherCourseStudent");

            migrationBuilder.RenameTable(
                name: "TeacherCourseStudent",
                newName: "TeacherCourseStudentTable");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherCourseStudent_TeacherId",
                table: "TeacherCourseStudentTable",
                newName: "IX_TeacherCourseStudentTable_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherCourseStudent_StudentId",
                table: "TeacherCourseStudentTable",
                newName: "IX_TeacherCourseStudentTable_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherCourseStudent_CourseId",
                table: "TeacherCourseStudentTable",
                newName: "IX_TeacherCourseStudentTable_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherCourseStudentTable",
                table: "TeacherCourseStudentTable",
                column: "TeacherCourseStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherCourseStudentTable_CourseTable_CourseId",
                table: "TeacherCourseStudentTable",
                column: "CourseId",
                principalTable: "CourseTable",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherCourseStudentTable_StudentTable_StudentId",
                table: "TeacherCourseStudentTable",
                column: "StudentId",
                principalTable: "StudentTable",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherCourseStudentTable_TeacherTable_TeacherId",
                table: "TeacherCourseStudentTable",
                column: "TeacherId",
                principalTable: "TeacherTable",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherCourseStudentTable_CourseTable_CourseId",
                table: "TeacherCourseStudentTable");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherCourseStudentTable_StudentTable_StudentId",
                table: "TeacherCourseStudentTable");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherCourseStudentTable_TeacherTable_TeacherId",
                table: "TeacherCourseStudentTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherCourseStudentTable",
                table: "TeacherCourseStudentTable");

            migrationBuilder.RenameTable(
                name: "TeacherCourseStudentTable",
                newName: "TeacherCourseStudent");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherCourseStudentTable_TeacherId",
                table: "TeacherCourseStudent",
                newName: "IX_TeacherCourseStudent_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherCourseStudentTable_StudentId",
                table: "TeacherCourseStudent",
                newName: "IX_TeacherCourseStudent_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherCourseStudentTable_CourseId",
                table: "TeacherCourseStudent",
                newName: "IX_TeacherCourseStudent_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherCourseStudent",
                table: "TeacherCourseStudent",
                column: "TeacherCourseStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherCourseStudent_CourseTable_CourseId",
                table: "TeacherCourseStudent",
                column: "CourseId",
                principalTable: "CourseTable",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherCourseStudent_StudentTable_StudentId",
                table: "TeacherCourseStudent",
                column: "StudentId",
                principalTable: "StudentTable",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherCourseStudent_TeacherTable_TeacherId",
                table: "TeacherCourseStudent",
                column: "TeacherId",
                principalTable: "TeacherTable",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
