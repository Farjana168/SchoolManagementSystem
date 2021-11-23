using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    public class CourseTable
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        [Range(1, 10, ErrorMessage = "CourseDuration must be greater than 0 and less than equal 10")]
        public int CourseDuration { get; set; }

        public IList<TeacherCourseStudent> TeacherCourseStudents { get; set; }

    }
}
