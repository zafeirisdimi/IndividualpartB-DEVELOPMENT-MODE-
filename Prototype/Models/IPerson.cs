using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public interface IPerson
    {
        string FirstName { get; }
        string LastName { get; }
        int Age { get; }
        string Phone { get; }
        int? CityId { get; }
      
    }
}
