using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class StudentPerCourse
    {
        [Key,Column(Order = 0)]
        public int StudentId { get; set; }

        [Key, Column(Order = 1)]
        public int CourseId { get; set; }

        [ForeignKey("Grade")]
        public int GradeId { get; set; }
        public Grade Grade { get; set; }


    }
}
