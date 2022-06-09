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
        [Key]
        public int TrainerId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(70, MinimumLength = 5)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 15)]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 10)]
        public string Phone { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Range(15, 100)]
        public int Age { get; set; }

        [Required]
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
