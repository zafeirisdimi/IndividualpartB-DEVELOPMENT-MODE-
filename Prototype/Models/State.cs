using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Prototype.Models
{
    public class State : ISimpleModel
    {
        // [StringLength(50, MinimumLength = 5, ErrorMessage = "Validation Error in State:Name")]
        //[StringLength(60, MinimumLength = 25, ErrorMessage = "Validation Error in State:Website")]
        public int StateId { get; set; }

        
       
        public string Name { get; set; }

        
        
        public string Website { get; set; }
        public ICollection<City> City { get; set; } //navigation property
    }
}
