using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Prototype.Models
{
    public class Trainer : IPerson
    {
        [Key]
        public int TrainerId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(70)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }

        [Required]
        public decimal Salary { get; set; }

        public int Age { get; set; }

        public int? CityId { get; set; } //foreign key --- relationship [0.1 to *]
        public City City { get; set; }

        public int? AssignmentId { get; set; } //foreign key --- relationship [0.1 to *]
        public Assignment Assignment { get; set; }
        public virtual ICollection<Course> Courses { get; set; } //navigation property
        public Trainer()
        {
            this.Courses = new HashSet<Course>(); //implementation relationship many to many
        }
    }
}
