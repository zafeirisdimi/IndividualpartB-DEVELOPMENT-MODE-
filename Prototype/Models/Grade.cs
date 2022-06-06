using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class Grade
    {

        public int GradeId { get; set; }
        public string GradeName { get; set; }

        public int GradeLevel { get; set; }

        public ICollection<Student> Students { get; set; }  //navigation property

        public ICollection<StudentPerCourse> StudentPerCourses { get; set; }  //navigation property  
    }
}
