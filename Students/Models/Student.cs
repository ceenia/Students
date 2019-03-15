using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Students.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public decimal Mark { get; set; }
    }

    public class StudentDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}