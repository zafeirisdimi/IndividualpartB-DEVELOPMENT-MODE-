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
            Console.WriteLine("|FirstName| \t|LastName| \t  |Phone| \t |Email| \t\t|TuitionFees|");
            foreach (var student in students)
            {
                
                Console.WriteLine($"|{student.FirstName,-15} {student.LastName,-15} {student.Phone,-15} {student.Email,-20}   {student.TuitionFees,-15}|");
            }
            Console.ResetColor();
        }

        
    }
}
