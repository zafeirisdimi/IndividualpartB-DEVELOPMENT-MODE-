using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Prototype.Models
{
    public class Grade
    {
        //[StringLength(20, MinimumLength = 5, ErrorMessage = "Validation Error in Grade:GradeName")]
        public int GradeId { get; set; }
        [Required]
        
        public string GradeName { get; set; }

        [Range(0, 20)]
        public int GradeLevel { get; set; }

        public ICollection<Student> Students { get; set; }  //navigation property

        
    }
}
