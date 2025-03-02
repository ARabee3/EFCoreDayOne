using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities;
internal class Course_Inst
{
    public int InstructorId { get; set; }
   // public Instructor Instructor { get; set; }  // Add this

    public int CourseId { get; set; }
    //public Course Course { get; set; }  // Add this

    public string Evaluate { get; set; }
}

