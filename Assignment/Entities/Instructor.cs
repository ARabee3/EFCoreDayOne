using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities;
internal class Instructor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Bonus { get; set; }
    public int Salary { get; set; }
    public string Address { get; set; }
    public int HourRate { get; set; }
    public int Dept_Id { get; set; }

}
