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


            if (context.Students.Count() == 0)
            {
                var students = ImportMockupData.ListOfStudents(@"\..\..\..\..\Prototype\Prototype\Json\mockup_students.json");
                context.Students.AddRange(students);
                
            }
            if (context.Trainers.Count() == 0)
            {
                var trainers = ImportMockupData.ListOfTrainers(@"\..\..\..\..\Prototype\Prototype\Json\mockup_trainers.json");
                context.Trainers.AddRange(trainers);
                
            }
            if (context.Assignments.Count() == 0)
            {
                var a = ImportMockupData.ListOfAssignments(@"\..\..\..\..\Prototype\Prototype\Json\mockup_assignments.json");
                context.Assignments.AddRange(a);
                
            }
            if (context.Courses.Count() == 0)
            {
                var courses = ImportMockupData.ListOfCourses(@"\..\..\..\..\Prototype\Prototype\Json\mockup_courses.json");
                context.Courses.AddRange(courses);
                
            }

            context.SaveChanges();








            






        }
    }
}
