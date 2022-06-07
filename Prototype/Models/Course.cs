using Prototype.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class Course : ISimpleModel
    {
        public  int CourseId { get; set; }

        public string Name { get; set; }
        public string  Description { get; set; }

        public Stream Stream { get; set; }

        public TypeCourse Type { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Difficulty Difficulty { get; set; }

        public int TotalHours { get; set; }
        public string Website { get ; set ; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Trainer> Trainers { get; set; }

        public virtual ICollection<Assignment> Assignments { get; set; }

        public Course()
        {
            this.Students = new HashSet<Student>();
            this.Trainers = new HashSet<Trainer>();
            this.Assignments = new HashSet<Assignment>();
        }
    }
}
