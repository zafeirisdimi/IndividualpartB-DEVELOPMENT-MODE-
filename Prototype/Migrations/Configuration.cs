namespace Prototype.Migrations
{
    using System.IO;
    using Prototype.Models;
    using Prototype.Services.MockupRepository;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Prototype.Enum;

    internal sealed class Configuration : DbMigrationsConfiguration<Prototype.ApplicationDatabase.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Prototype.ApplicationDatabase.ApplicationContext context)
        {

            //Realistic Data Entry to test my application
            Student s1 = new Student() { FirstName = "Aristotelis", LastName = "Nikolaou", Phone = "2104512987", Email = "nikolaou@hotmail.com", TuitionFees = 2500, Age = 32 };
            Student s2 = new Student() { FirstName = "Panagiotis", LastName = "Pipiros", Phone = "2107755986", Email = "pipiros@yahoo.com", TuitionFees = 2000, Age = 32 };
            Student s3 = new Student() { FirstName = "Eleni", LastName = "Adamantou", Phone = "2104411202", Email = "eleni.a@gmail.com", TuitionFees = 2200, Age = 30 };
            Student s4 = new Student() { FirstName = "Patric", LastName = "Jackson", Phone = "2103636990", Email = "patric@hotmail.com", TuitionFees = 1500, Age = 25 };
            Student s5 = new Student() { FirstName = "Christin", LastName = "Muller", Phone = "214748449", Email = "muller@gmail.com", TuitionFees = 1000, Age = 27 };
            context.Students.AddOrUpdate(s => s.FirstName, s1, s2, s3, s4, s5);
           

            Trainer t1 = new Trainer() { FirstName = "Panagiotis", LastName = "Papadopoulou", Phone = "214748449", Email = "christinapapa@gmail.com", Salary = 3000, Age = 40, Subject = Subject.HTML_FUNDANMENTALS };
            Trainer t2 = new Trainer() { FirstName = "Sandra", LastName = "Nikolaidi", Phone = "214748449", Email = "christinapapa@gmail.com", Salary = 4000, Age = 45, Subject = Subject.CSHARP_FUNDENMENTALS };
            Trainer t3 = new Trainer() { FirstName = "Eva", LastName = "Kotroni", Phone = "214748449", Email = "christinapapa@gmail.com", Salary = 3300, Age = 37, Subject = Subject.SQL_FUNDENMENTALS };
            Trainer t4 = new Trainer() { FirstName = "Menelaos", LastName = "Adamantos", Phone = "214748449", Email = "christinapapa@gmail.com", Salary = 3500, Age = 41, Subject = Subject.JS_FUNDENMENTALS };
            context.Trainers.AddOrUpdate(t => t.FirstName, t1, t2, t3, t4);

            Course c1 = new Course() { Name = "HTML FUNDENMENTALS", Description = "HTML Fundamentals for developers", TotalHours = 40, Difficulty = Difficulty.Easy};
            Course c2 = new Course() { Name = "CSS  FUNDENMENTALS", Description = "CSS  Fundamentals for developers", TotalHours = 40, Difficulty = Difficulty.Easy};
            Course c3 = new Course() { Name = "JS   FUNDENMENTALS", Description = "JS   Fundamentals for developers", TotalHours = 100, Difficulty = Difficulty.Normal };
            Course c4 = new Course() { Name = "C#   FUNDENMENTALS", Description = "C#   Fundamentals for developers", TotalHours = 150, Difficulty = Difficulty.Hard};
            Course c5 = new Course() { Name = "SQL  FUNDENMENTALS", Description = "SQL  Fundamentals for developers", TotalHours = 80, Difficulty = Difficulty.Hard };
            context.Courses.AddOrUpdate(c => c.Name, c1, c2, c3, c4, c5);

            Assignment a1 = new Assignment() { Name = "Assignment 1", Description = "HTML Fundamentals for developers", StartDate =DateTime.Now , EndDate = DateTime.Now.AddDays(7) };
            Course a2 = new Course() { Name = "Assignment 2", Description = "CSS  Fundamentals for developers", StartDate = DateTime.Now, EndDate = DateTime.Now.AddHours(24) };
            Course a3 = new Course() { Name = "Assignment 3", Description = "JS   Fundamentals for developers", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(14) };
            Course a4 = new Course() { Name = "Assignment 4", Description = "C#   Fundamentals for developers", StartDate = DateTime.Now, EndDate = DateTime.Now.AddHours(72) };
            Course a5 = new Course() { Name = "Assignment 5", Description = "SQL  Fundamentals for developers", StartDate = DateTime.Now.AddHours(24), EndDate = DateTime.Now.AddDays(28) };

            context.SaveChanges();
















        }
    }
}
