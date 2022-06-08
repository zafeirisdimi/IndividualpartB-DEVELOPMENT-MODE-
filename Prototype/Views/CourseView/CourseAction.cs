using Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Views.CourseView
{
    public static class CourseAction
    {

        public static void PrintAllCourses(List<Course> courses)

        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t|Name|\t\t\t|Description|\t\t|Difficulty|\t\t|TotalHours|");
            foreach (var course in courses)
            {
                PrintInfo(course);
            }
            Console.ResetColor();
        }

        public static void PrintInfo(Course course) => Console.WriteLine($"\t|{course.Name,-15}\t{course.Description,-20}\t{course.Difficulty,-15}{course.TotalHours,-15}|");
        public static void PrintExtend(Course course) => Console.WriteLine($"\t\t|Title: {course.Name}\t has: ({course.Students.Count()}) students");


    }
}
