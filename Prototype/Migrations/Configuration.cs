namespace Prototype.Migrations
{
    using System.IO;
    using Prototype.Models;
    using Prototype.Services.MockupRepository;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Prototype.ApplicationDatabase.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Prototype.ApplicationDatabase.ApplicationContext context)
        {
            //Realistic Data Entry to test my application
            // Student s1 = new Student() { FirstName = "Aristotelis", LastName = "Nikolaou", Phone = "2104512987", Email = "nikolaou@hotmail.com", Revenue = 2500 };
            // Student s2 = new Student() { FirstName = "Panagiotis", LastName = "Pipiros", Phone = "2107755986", Email = "pipiros@yahoo.com", Revenue = 2000 };
            // Student s3 = new Student() { FirstName = "Eleni", LastName = "Adamantopoulou", Phone = "2104411202", Email = "eleni.a@gmail.com", Revenue = 2200 };
            // Student s4 = new Student() { FirstName = "Patric", LastName = "Jackson", Phone = "2103636990", Email = "menelaosargi@hotmail.com", Revenue = 1500 };
            // Student s5 = new Student() { FirstName = "Christin", LastName = "Muller", Phone = "214748449", Email = "christinapapa@gmail.com", Revenue = 1000 };
            //context.Students.AddOrUpdate(s => s.FirstName, s1, s2, s3, s4, s5);

            //Trainer t1 = new Trainer() { FirstName = "Panagiotis", LastName = "Papadopoulou", Phone = "214748449", Email = "christinapapa@gmail.com", Salary = 3000 };
            //Trainer t2 = new Trainer() { FirstName = "Sandra", LastName = "Nikolaidi", Phone = "214748449", Email = "christinapapa@gmail.com", Salary = 4000 };
            //Trainer t3 = new Trainer() { FirstName = "Eva", LastName = "Kotroni", Phone = "214748449", Email = "christinapapa@gmail.com", Salary = 3300 };
            //Trainer t4 = new Trainer() { FirstName = "Menelaos", LastName = "AdamantopouloS", Phone = "214748449", Email = "christinapapa@gmail.com", Salary = 3500 };
            //context.Trainers.AddOrUpdate(t => t.FirstName, t1, t2, t3, t4);

            //Course c1 = new Course() { Title = "HTML FUNDENMENTALS", Description = "HTML Fundamentals for  developers", TotalHours = 40 };
            //Course c2 = new Course() { Title = "CSS FUNDENMENTALS", Description = "CSS Fundamentals for developers", TotalHours = 40 };
            //Course c3 = new Course() { Title = "JS FUNDENMENTALS", Description = "JS Fundamentals for developers", TotalHours = 100 };
            //Course c4 = new Course() { Title = "C# FUNDENMENTALS", Description = "C# Fundamentals for developers", TotalHours = 150 };
            //Course c5 = new Course() { Title = "SQL FUNDENMENTALS", Description = "SQL Fundamentals for developers", TotalHours = 80 };
            //context.Courses.AddOrUpdate(c => c.Title, c1, c2, c3, c4, c5);

            if (context.Students.Count() == 0)
            {
                var students = ImportMockupData.ListOfStudents(@"\..\..\..\..\Prototype\Prototype\\mockup_students.json");
                context.Students.AddRange(students);
                context.SaveChanges();
            }
            if (context.Trainers.Count() == 0)
            {
                var trainers = ImportMockupData.ListOfTrainers(@"\..\..\..\..\Prototype\Prototype\Json\mockup_trainers.json");
                context.Trainers.AddRange(trainers);
                context.SaveChanges();
            }
            if (context.Assignments.Count() == 0)
            {
                var a = ImportMockupData.ListOfAssignments(@"\..\..\..\..\Prototype\Prototype\Json\mockup_assignments.json");
                context.Assignments.AddRange(a);
                context.SaveChanges();
            }
            if (context.Courses.Count() == 0)
            {
                var courses = ImportMockupData.ListOfCourses(@"\..\..\..\..\Prototype\Prototype\Json\mockup_courses.json");
                context.Courses.AddRange(courses);
                context.SaveChanges();
            }




           

            


            
            context.SaveChanges();






        }
    }
}
