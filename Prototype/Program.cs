using Prototype.ApplicationDatabase;
using Prototype.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {



            ApplicationContext db = new ApplicationContext();
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu.Run();
            }
        }
    }
}
