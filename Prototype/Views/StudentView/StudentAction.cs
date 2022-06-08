using Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Views.StudentView
{
    public static class StudentAction
    {
        public static void  PrintAllStudents(List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|FirstName| \t|LastName| \t  |Phone| \t |Email| \t|TuitionFees|");
            foreach (var student in students)
            {
                PrintInfo(student);
            }
            Console.ResetColor();
        }

        public static void PrintInfo(Student student) => Console.WriteLine($"|{student.FirstName,-15}{student.LastName,-15}{student.Phone,-15}{student.Email,-22}{student.TuitionFees,-15}|");
        public static void PrintShort(Student student) => Console.WriteLine($"\t\t\t\t\t\t\t Student {student.FirstName,-10}\t{student.LastName,-10} ");
        public static void PrintExtend(Student student) => Console.WriteLine($"\t\t Student {student.FirstName,-10}\t{student.LastName,-10} has ({student.Courses.Count()}) courses ");



    }
}
