using Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Views.AssignmentView
{
    public static class AssigmentAction
    {
        public static void PrintAllAssignments(List<Assignment> assignments)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t|Name  |\t|  Description|\t|DownloadLink|\t|StartDate|\t|EndDate|\t|Points|");
            foreach (var assignment in assignments)
            {
                PrintInfo(assignment);
            }
        }

        public static void PrintInfo(Assignment assignment)
        {
            Console.WriteLine($"\t|{assignment.Name,-15}\t{assignment.Description,-15}\t{assignment.DownloadLink,-15}\t{assignment.Points}\t{assignment.StartDate}\t{assignment.EndDate}\t{assignment.Points}");
        }

        public static void PrintExtend(Assignment assignment)
        {
            Console.WriteLine($"\t\t\t\t\t\t\t|Title: {assignment.Name}\t|Points: {assignment.Points}\t|StartDate: {assignment.StartDate}\t|StartDate: {assignment.EndDate}");
        }


        }

    }

