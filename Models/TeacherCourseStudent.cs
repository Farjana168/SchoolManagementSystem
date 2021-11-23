using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    public class TeacherCourseStudent
    {
        [Key]
        public int TeacherCourseStudentId { get; set; }
        [Required]
        public string TeacherCourseStudentSection { get; set; }

        public int TeacherId { get; set; }
        public TeacherTable Teacher { get; set; }
        public int CourseId { get; set; }
        public CourseTable Course { get; set; }


        public int StudentId { get; set; }
        public StudentTable Student { get; set; }

    }
}
