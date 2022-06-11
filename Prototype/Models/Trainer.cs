using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Prototype.Enum;

namespace Prototype.Models
{
    public class Trainer : IPerson
    {
        //[StringLength(50, MinimumLength = 5,ErrorMessage = "Validation Error in Trainer:FirstName")]
        //[StringLength(70, MinimumLength = 5, ErrorMessage = "Validation Error in Trainer:LastName")]
        //[StringLength(100, MinimumLength = 15, ErrorMessage = "Validation Error in Trainer:Email")]
        //[StringLength(20, MinimumLength = 10, ErrorMessage = "Validation Error in Trainer:Phone")]


        
        public int TrainerId { get; set; }

        
        
        public string FirstName { get; set; }

       
        
        public string LastName { get; set; }

        
        
        public string Email { get; set; }

        
        
        public string Phone { get; set; }

        
        public decimal Salary { get; set; }

        
        public int Age { get; set; }

        
        public Subject Subject { get; set;  }

        public int? CityId { get; set; } //foreign key --- relationship [0.1 to *]
        public City City { get; set; }

        
        public virtual ICollection<Course> Courses { get; set; } //navigation property
        public virtual ICollection<Student> Students { get; set; } //navigation property



        public Trainer()
        {
            
            this.Courses = new HashSet<Course>(); //implementation relationship many to many
            this.Students = new HashSet<Student>();
        }
    }
}
