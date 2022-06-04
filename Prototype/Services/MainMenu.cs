using Prototype.Models;
using Prototype.Views.StudentView;
using Prototype.Views.TrainerView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Services
{
    public static class MainMenu
    {
        public static bool Run()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t Choose an option");
            Console.WriteLine("\t\t 1) Show all the students");
            Console.WriteLine("\t\t 2) Show all the trainers");
            Console.WriteLine("\t\t 3) Show all the courses");
            Console.WriteLine("\t\t 4) Show all the assignments");
            Console.WriteLine("\t\t 5) Show all the students per course");
            Console.WriteLine("\t\t 6) Show all the trainers per course");
            Console.WriteLine("\t\t 7) Show all the assignments per course");
            Console.WriteLine("\t\t 8) Show all the assignments per course per student");
            Console.WriteLine("\t\t 9) Show a list of students that belong to more than one courses");
            Console.WriteLine("\t\t 10 Exit");
            Console.Write("\r\n\t Select an option: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Choice choice = (Choice)input;
            switch (choice)
            {
                case Choice.PrintAllStudents:
                    //StudentAction.PrintAllStudents();
                    return true;
                case Choice.PrintAllTrainers:
                    //TrainerAction.PrintAllTrainers();
                    return true;
                case Choice.PrintAllCourses:
                    //service PrintAllCourses();
                    return true;
                case Choice.PrintAllAssignments:
                    // service PrintAllCourses();
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
                ////case "10":
                //    //PrintAllCourses();
                //    return true;
                default:
                    return true;
            }


        }
    }
}
