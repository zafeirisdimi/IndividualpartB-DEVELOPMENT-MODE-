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
            foreach (var assignment in assignments)
            {
                Console.WriteLine($"|{assignment.Name,-15} {assignment.Description,-15} {assignment.Website,-15} {assignment.DownloadLink,-15} {assignment.Points} {assignment.StartDate}{assignment.EndDate}|");
            }
        }
        }
    }

