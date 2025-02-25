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
    public int Inst_ID { get; set; }

    public int Course_ID { get; set; }
    public string Evaluate {  get; set; }
}
