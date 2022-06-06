using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Prototype.Models
{
    public class Student : IPerson
    {
        [Key]
        public int StudentId { get; set; }

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
        public decimal Revenue { get; set; }

        public int Age { get; set; }

        public int? GradeId { get; set; }// foreign key --- relationship [0.1 to *]
        public Grade Grade { get; set; }


        public int? CityId { get; set; } //foreign key --- relationship [0.1 to *]
        public City City { get; set; }

        public int? AssignmentId { get; set; } //foreign key --- relationship [0.1 to *]
        public Assignment Assignment { get; set; }


        public int? CourseId { get; set; }//foreign key -- realationship [* to *]
        public virtual ICollection<Course> Courses { get; set; } //navigation property


        public Student()
        {
            this.Courses = new HashSet<Course>(); //implementation relationship many to many



        }

    }
}
