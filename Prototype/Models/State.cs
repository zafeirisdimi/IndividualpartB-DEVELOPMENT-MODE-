using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class State : ISimpleModel
    {
        public int StateId { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }
        public ICollection<City> City { get; set; } //navigation property
    }
}
