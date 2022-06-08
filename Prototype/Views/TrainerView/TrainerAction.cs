using Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Views.TrainerView
{
    public static class TrainerAction
    {
        public static void PrintAllTrainers(List<Trainer> trainers)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|FirstName| \t|LastName| \t  |Phone| \t |Email| \t|Salary|");

            foreach (var trainer in trainers)
            {
                PrintInfo(trainer);
            }
            Console.ResetColor();

        }

        public static void PrintInfo(Trainer trainer) => Console.WriteLine($"|{trainer.FirstName,-15} {trainer.LastName,-15} {trainer.Phone,-15} {trainer.Email,-15} {trainer.Salary,-15}|");
        public static void PrintShort(Trainer trainer) => Console.WriteLine($"\t\t\t\t\t\t\t Trainer {trainer.FirstName,-10}\t{trainer.LastName,-10} ");
        public static void PrintExtend(Trainer trainer) => Console.WriteLine($"\t\t Trainer {trainer.FirstName,-10}\t{trainer.LastName,-10} has ({trainer.Courses.Count()}) courses ");

    }
}
