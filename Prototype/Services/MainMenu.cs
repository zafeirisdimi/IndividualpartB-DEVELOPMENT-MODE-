using Prototype.ApplicationDatabase;
using Prototype.Models;
using Prototype.Views.AssignmentView;
using Prototype.Views.CourseView;
using Prototype.Views.StudentView;
using Prototype.Views.TrainerView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prototype.Services
{
    public static class MainMenu
    {
        public static bool Run()
        {
            Menu();
            int input = Convert.ToInt32(Console.ReadLine());
            Choice choice = (Choice)input;
            switch (choice)
            {
                case Choice.PrintAllStudents:

                    ApplicationContext c1 = new ApplicationContext();
                    var students = c1.Students.ToList();
                    StudentAction.PrintAllStudents(students);
                    Thread.Sleep(6000);
                    return true;

                case Choice.PrintAllTrainers:
                    
                    ApplicationContext c2 = new ApplicationContext();
                    var trainers = c2.Trainers.ToList();
                    TrainerAction.PrintAllTrainers(trainers);
                    Thread.Sleep(6000);
                    return true;

                case Choice.PrintAllCourses:

                    ApplicationContext c3 = new ApplicationContext();
                    var courses = c3.Courses.ToList();
                    CourseAction.PrintAllCourses(courses);
                    Thread.Sleep(6000);
                    return true;

                case Choice.PrintAllAssignments:
                    ApplicationContext c4 = new ApplicationContext();
                    var assignments = c4.Assignments.ToList();
                    AssigmentAction.PrintAllAssignments(assignments);
                    Thread.Sleep(6000);
                    return true;

                //case "PrintStudentsPerCourse":
                ////    //PrintAllCourses();
                ////    return true;
                ////case "6":
                ////    //PrintAllCourses();
                ////    return true;
                ////case "7":
                ////   // PrintAllCourses();
                ////    return true;
                ////case "8":
                ////   // PrintAllCourses();
                ////case "9":
                ////    //PrintAllCourses();
                case Choice.Exit:
                    return false;
               
                default:
                    Console.WriteLine("You typed something wrong,try again!");
                    return true;
            }
            

        }

        private static void Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("____________________________________________________________________________________");
            Console.WriteLine("|\t Choose an option");
            Console.WriteLine("|\t\t 1) Show all the students");
            Console.WriteLine("|\t\t 2) Show all the trainers");
            Console.WriteLine("|\t\t 3) Show all the courses");
            Console.WriteLine("|\t\t 4) Show all the assignments");
            Console.WriteLine("|\t\t 5) Show all the students per course");
            Console.WriteLine("|\t\t 6) Show all the trainers per course");
            Console.WriteLine("|\t\t 7) Show all the assignments per course");
            Console.WriteLine("|\t\t 8) Show all the assignments per course per student");
            Console.WriteLine("|\t\t 9) Show a list of students that belong to more than one courses");
            Console.WriteLine("|\t\t 10 Exit");
            Console.WriteLine("____________________________________________________________________________________");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\r\n\t Select an option: ");
            

        }
    }
}
