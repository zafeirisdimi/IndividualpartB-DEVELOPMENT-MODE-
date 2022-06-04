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
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal Revenue { get; set; }



        public int? GradeId { get; set; }//foreign key
        

        public int? CourseId { get; set; }//foreign key
        


        //navigation properties
        public virtual ICollection<Grade> Grades { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
        public Grade Grade { get; set; }
        public Course Course { get; set; }

        public int Age { get; set; }

        public int CityId { get; set; }

        public int StateId { get; set; }

        //default constructor
        public Student()
        {

        }

    }
}
