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

            #region Students
            Student s1 = new Student() { FirstName = "Aristotelis", LastName = "Nikolaou", Phone = "2104512987", Email = "nikolaou@hotmail.com", TuitionFees = 2500, Age = 32};
            Student s2 = new Student() { FirstName = "Panagiotis", LastName = "Pipiros", Phone = "2107755986", Email = "pipiros@yahoo.com", TuitionFees = 2000, Age = 32 };
            Student s3 = new Student() { FirstName = "Eleni", LastName = "Adamantou", Phone = "2104411202", Email = "eleni.a@gmail.com", TuitionFees = 2200, Age = 30 };
            Student s4 = new Student() { FirstName = "Patric", LastName = "Jackson", Phone = "2103636990", Email = "patric@hotmail.com", TuitionFees = 1500, Age = 25 };
            Student s5 = new Student() { FirstName = "Christin", LastName = "Muller", Phone = "214748449", Email = "muller@gmail.com", TuitionFees = 1000, Age = 27 };
            context.Students.AddOrUpdate(s => s.FirstName, s1, s2, s3, s4, s5);
            context.SaveChanges();
            #endregion

            #region Trainers
            Trainer t1 = new Trainer() { FirstName = "Panagiotis", LastName = "Papadopoulou", Phone = "214748449", Email = "christinapapa@gmail.com", Salary = 3000, Age = 40, Subject = Subject.HTML_FUNDANMENTALS};
            Trainer t2 = new Trainer() { FirstName = "Sandra", LastName = "Nikolaidi", Phone = "214748449", Email = "christinapapa@gmail.com", Salary = 4000, Age = 45, Subject = Subject.CSHARP_FUNDENMENTALS };
            Trainer t3 = new Trainer() { FirstName = "Eva", LastName = "Kotroni", Phone = "214748449", Email = "christinapapa@gmail.com", Salary = 3300, Age = 37, Subject = Subject.SQL_FUNDENMENTALS };
            Trainer t4 = new Trainer() { FirstName = "Menelaos", LastName = "Adamantos", Phone = "214748449", Email = "christinapapa@gmail.com", Salary = 3500, Age = 41, Subject = Subject.JS_FUNDENMENTALS };
            context.Trainers.AddOrUpdate(t => t.FirstName, t1, t2, t3, t4);
            context.SaveChanges();
            #endregion


            #region Courses
            Course c1 = new Course() { Name = "HTML FUNDENMENTALS", Description = "HTML basics", TotalHours = 40, Difficulty = Difficulty.Easy};
            Course c2 = new Course() { Name = "CSS  FUNDENMENTALS", Description = "CSS  basics ", TotalHours = 40, Difficulty = Difficulty.Easy };
            Course c3 = new Course() { Name = "JS   FUNDENMENTALS", Description = "JS   basics ", TotalHours = 100, Difficulty = Difficulty.Normal };
            Course c4 = new Course() { Name = "C#   FUNDENMENTALS", Description = "C#   basics ", TotalHours = 150, Difficulty = Difficulty.Hard };
            Course c5 = new Course() { Name = "SQL  FUNDENMENTALS", Description = "SQL  basics", TotalHours = 80, Difficulty = Difficulty.Hard };
            context.Courses.AddOrUpdate(c => c.Name, c1, c2, c3, c4, c5);
            context.SaveChanges();
            #endregion


            #region Assignments
            Assignment a1 = new Assignment() { Name = "Assignment 1", Description = "HTML webpage", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(7), DownloadLink = "https://a1.html", Points = 30};
            Assignment a2 = new Assignment() { Name = "Assignment 2", Description = "CSS  tricks", StartDate = DateTime.Now, EndDate = DateTime.Now.AddHours(24) , DownloadLink = "https://a2.html", Points = 40 };
            Assignment a3 = new Assignment() { Name = "Assignment 3", Description = "JS   crud", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(14), DownloadLink = "https://a3.html", Points = 50 };
            Assignment a4 = new Assignment() { Name = "Assignment 4", Description = "C#   interfaces", StartDate = DateTime.Now, EndDate = DateTime.Now.AddHours(72), DownloadLink = "https://a4.html", Points = 100 };
            Assignment a5 = new Assignment() { Name = "Assignment 5", Description = "SQL  database", StartDate = DateTime.Now.AddHours(24), EndDate = DateTime.Now.AddDays(28), DownloadLink = "https://a5.html", Points = 65 };
            context.Assignments.AddOrUpdate(a => a.Name, a1, a2, a3, a4, a5);
            context.SaveChanges();
            #endregion


            #region Cities
            City city1 = new City() { Name = "Athens", Website = "https://en.wikipedia.org/wiki/Athens" };
            City city2 = new City() { Name = "Thessaloniki", Website = "https://en.wikipedia.org/wiki/Thessaloniki" };
            City city3 = new City() { Name = "Patra", Website = "https://en.wikipedia.org/wiki/Patras" };
            City city4 = new City() { Name = "Irakleio", Website = "https://en.wikipedia.org/wiki/Irakleio" };
            City city5 = new City() { Name = "Larissa", Website = "https://en.wikipedia.org/wiki/Larissa" };
            City city6 = new City() { Name = "Ioannina", Website = "https://en.wikipedia.org/wiki/Ioannina" };
            City city7 = new City() { Name = "Volos", Website = "https://en.wikipedia.org/wiki/Volos" };
            context.Cities.AddOrUpdate(city => city.Name, city1, city2, city3, city4, city5,city6, city7);
            context.SaveChanges();
            #endregion


            #region States
            State st1 = new State() { Name = "Attiki", Website = "https://en.wikipedia.org/wiki/Athens" };
            State st2 = new State() { Name = "Makedonia", Website = "https://en.wikipedia.org/wiki/Athens" };
            State st3 = new State() { Name = "Peloponnese", Website = "https://en.wikipedia.org/wiki/Athens" };
            State st4 = new State() { Name = "Crete", Website = "https://en.wikipedia.org/wiki/Athens" };
            State st5 = new State() { Name = "Thessaly", Website = "https://en.wikipedia.org/wiki/Athens" };
            State st6 = new State() { Name = "Thrace", Website = "https://en.wikipedia.org/wiki/Athens" };
            context.States.AddOrUpdate(st => st.Name, st1, st2, st3, st4, st5, st6);
            context.SaveChanges();
            #endregion
        }
    }
}
