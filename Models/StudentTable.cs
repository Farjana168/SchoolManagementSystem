using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    public class StudentTable
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        [StringLength(11, ErrorMessage = "Phone number length can't be more than 11.")]
        public string StudentPhone { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Gender length can't be more than 10.")]
        public string StudentGender { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Address length can't be more than 50.")]
        public string StudentAddress { get; set; }
       
        public IList<TeacherCourseStudent> TeacherCourseStudents { get; set; }
    }
}
