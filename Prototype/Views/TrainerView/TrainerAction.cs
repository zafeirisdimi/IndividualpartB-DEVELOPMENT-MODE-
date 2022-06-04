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
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"|{trainer.FirstName,-15} {trainer.LastName,-15} {trainer.Phone,-15} {trainer.Email,-15} {trainer.Salary,-15}|");
            }
        }
    }
}
