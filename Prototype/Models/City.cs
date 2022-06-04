using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class City : ISimpleModel

    {
        public int CityId { get; set; }
        public string Name { get; set; }

        public string Website { get; set; }
        public int? StateId { get; set; }
        public State State { get; set; }
        
    }
}
