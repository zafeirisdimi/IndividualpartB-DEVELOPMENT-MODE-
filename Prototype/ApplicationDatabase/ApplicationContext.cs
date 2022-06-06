using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Prototype.Models;

namespace Prototype.ApplicationDatabase
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("Sindesmos")
        {

        }

        //--------------DbSet <Entity> Entities -------------
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentPerCourse> StudentPerCourses { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
    }
}
