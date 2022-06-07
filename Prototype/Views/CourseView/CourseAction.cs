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
            Console.WriteLine("|  Name  | \t\t\t|  Description  |     \t\t|  Website  |     \t\t|  TotalHours  |   \t\t|  TuitionFees  |");
            foreach (var course in courses)
            {
                Console.WriteLine($"|{course.Name,-15}  {course.Description,-20}\t{course.Website,-15}\t{course.TotalHours,-15}|");
            }
            Console.ResetColor();
        }
    }
}
