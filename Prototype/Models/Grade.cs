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
        public Student Student { get; set; }
        public int StudentId { get; set; }

        //navigation properties
        public ICollection<Student> Students { get; set; }  
    }
}
