using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class Trainer : IPerson
    {
        public int TrainerId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; }

        public int Age { get; set; }

        public int CityId { get; set; }

        public int StateId { get; set; }

        //default constructor
        public Trainer()
        {

        }
    }
}
