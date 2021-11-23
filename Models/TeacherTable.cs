using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    public class TeacherTable
    {
        [Key]
        public int TeacherId { get; set; }
        [Required]
        public string TeacherName { get; set; }
        [Required]
        [StringLength(11, ErrorMessage = "Phone number length can't be more than 11.")]
        public string TeacherPhone { get; set; }
        [Required]
        [EmailAddress]
        public string TeacherEmail { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Address length can't be more than 50.")]
        public string TeacherAddress { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Gender length can't be more than 11.")]
        public string TeacherGender { get; set; }
        [Required]
        public DateTime TeacherDOB { get; set; }


        
        public IList<TeacherCourseStudent> TeacherCourseStudents { get; set; }
    }
}
