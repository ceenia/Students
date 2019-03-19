namespace Students.Migrations
{
    using Students.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Students.Models.StudentDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Students.Models.StudentDBContext context)
        {
            context.Students.AddOrUpdate(i => i.Name,
                new Student
                {
                    Name= "Abc",
                    Dob = DateTime.Parse("1989-1-11"),
                    Gender = "Female",
                    Mark = 79,
                    Status = "Pass",
                    Email = "ceeniajoseph@gmail.com"
                },
                new Student
                {
                    Name = "Bcd",
                    Dob = DateTime.Parse("1989-1-11"),
                    Gender = "Male",
                    Mark = 79,
                    Status = "Pass",
                    Email = "ceeniajoseph@gmail.com"
                }
           );
        }
    }
}
