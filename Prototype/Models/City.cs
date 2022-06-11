using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Prototype.Models
{
    public class City : ISimpleModel

    {

        //[StringLength(50, MinimumLength = 5, ErrorMessage = "Validation Error in City:Name")]
        //[StringLength(100, MinimumLength = 15, ErrorMessage = "Validation Error in Assignment:Website")]
        public int CityId { get; set; }
        
        
        public string Name { get; set; }

     
        
        public string Website { get; set; }
        public int? StateId { get; set; } // foreign key
        public State State { get; set; }
        public ICollection<Trainer> Trainers{ get; set; } //navigation property
        public ICollection<Student> Students{ get; set; } //navigation property

    }
}
