using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext>options):base(options)
        {

        }
        public DbSet<CourseTable> CourseTable { get; set; }
        public DbSet<StudentTable> StudentTable { get; set; }
        public DbSet<TeacherTable> TeacherTable { get; set; }
        public DbSet<TeacherCourseStudent> TeacherCourseStudentTable { get; set; }

    }
}
