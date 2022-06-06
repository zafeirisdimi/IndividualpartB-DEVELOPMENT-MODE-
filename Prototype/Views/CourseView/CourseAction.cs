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
            foreach (var course in courses)
            {
                Console.WriteLine($"|{course.Name,-15} {course.Description,-15} {course.Website,-15} {course.TotalHours,-15}|");
            }
        }
    }
}
