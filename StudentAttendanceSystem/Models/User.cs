﻿
using System.ComponentModel.DataAnnotations;

namespace StudentAttendanceSystem.Models
{
    public class User

    {

        [Key]
        public int Id { get; set; } // Primary key

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

    }
}
