using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MigrationsAndCodeFirst.Entities
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }

    }
}
