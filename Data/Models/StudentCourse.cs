using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerTutorial.Data.Models
{
    public class StudentCourse
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Semester { get; set; }
        [Required]
        public int CalendarYear { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        public int StudentId { get; set; }

        public StudentCourse()
        {

        }
    }
}
