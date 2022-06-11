using Prototype.ApplicationDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Prototype.Services
{
    public static class MyInsertDB
    {
        public static void StudentsPerCourse()
        {
            using (var ctx = new ApplicationContext())
            {
                int studentsPerCourse = ctx.Database.ExecuteSqlCommand("INSERT INTO [dbo].[StudentCourses]([Student_StudentId],[Course_CourseId])VALUES(2, 1),(1, 2),(1, 3),(2, 2),(3, 1),(4, 1),(4, 2),(4, 4),(4, 5),(5, 1)");

            }
        }

        public static void StudentsPerAssignment()
        {
            using (var ctx = new ApplicationContext())
            {
                int studentsPerAssignment = ctx.Database.ExecuteSqlCommand("INSERT INTO [dbo].[StudentAssignments]([Student_StudentId],[Assignment_AssignmentId])VALUES(2,1),(1,2),(1,3),(2,2),(3,1),(4,1),(4,2),(4,4),(4,5),(5,1)");
            }
        }

        public static void CoursesPerAssignment()
        {
            using (var ctx = new ApplicationContext())
            {
                int coursesPerAssignment = ctx.Database.ExecuteSqlCommand("INSERT INTO [dbo].[CourseAssignments]([Course_CourseId],[Assignment_AssignmentId])VALUES(2, 1),(1, 2),(1, 3),(2, 2),(3, 1),(4, 1),(4, 2),(4, 4),(4, 5),(5, 1)");
            }
        }
        public static void TrainersPerCourse()
        {
            using (var ctx = new ApplicationContext())
            {
                int trainerPerCourse = ctx.Database.ExecuteSqlCommand("INSERT INTO [dbo].[TrainerCourses]([Trainer_TrainerId],[Course_CourseId])VALUES(1, 1),(1, 2),(1, 3),(2, 2),(3, 1),(4, 1),(4, 2),(4, 4),(4, 5),(5, 1)");
            }
        }

        public static void TrainersPerStudents()
        {
            using (var ctx = new ApplicationContext())
            {
                int trainerPerStudent = ctx.Database.ExecuteSqlCommand("INSERT INTO [dbo].[TrainerStudents]([Trainer_TrainerId] ,[Student_StudentId])VALUES(1, 1),(1, 2),(1, 3),(2, 1),(2, 2),(3, 3),(3, 4),(4, 4),(4, 5),(5, 1)");
            }
        }

    }
}
