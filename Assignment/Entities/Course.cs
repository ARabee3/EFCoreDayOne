using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities;
internal class Course
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public int Duration { get; set; }
    public string? Description { get; set; }
    public List<Course_Inst> Instructors { get; set; }
    public List<Stud_Course> Students { get; set; }
    public int TopicId { get; set; }
    public Topic Topic { get; set; }



}
