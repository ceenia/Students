using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Students.Models
{
    public class Student
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength =3)]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
  //      [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime Dob { get; set; }

        [Required]
        public string Gender { get; set; }

        [Range(1,100)]
        public decimal Mark { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [StringLength(7)]
        public string Status { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }

    public class StudentDBContext : DbContext
    {
        internal object students;

        public DbSet<Student> Students { get; set; }
    }
}