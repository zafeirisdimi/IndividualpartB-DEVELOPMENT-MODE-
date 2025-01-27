﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Prototype.Models
{
    public class Assignment : ISimpleModel
    {

        //[StringLength(50, MinimumLength = 5, ErrorMessage = "Validation Error in Assignment:Name")]
        //[StringLength(50, MinimumLength = 5, ErrorMessage = "Validation Error in Assignment:Description")]
        //[StringLength(100, MinimumLength = 10, ErrorMessage = "Validation Error in Assignment:DownloadLink")]
        //[StringLength(100, MinimumLength = 10, ErrorMessage = "Validation Error in Assignment:Website")]
        public int AssignmentId { get; set; }
       
        
        public string Name { get; set; }

        
        
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        
        public int Points { get; set; }

       
        public string DownloadLink { get; set; }

        public bool IsSubmitted { get; set; }

        public bool IsUploaded { get; set; }

        public int? TrainerId { get; set; }//foreign key
        public int? CourseID { get; set; }//foreign key

       
        
        public string Website { get ; set; }

        public virtual ICollection<Student> Students { get; set; } //navigation property
        public virtual ICollection<Course> Courses { get; set; } //navigation property

        public Assignment()
        {
            this.Courses = new HashSet<Course>(); //implementation relationship many to many
            this.Students = new HashSet<Student>();
        }

    }
}
