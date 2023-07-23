
using System.ComponentModel.DataAnnotations;

namespace StudentAttendanceSystem.Models
{
    public class Attendance
    {
        [Key]
        public int AttedanceId { get; set; } // Primary key

        public String? UserStudentId { get; set; } // Foreign key
        public bool Status { get; set; }

        public DateTime Date { get; set; }

    }
}