﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities;
internal class Topic
{
    public int Id { get; set; }
    public string Name { get; set; }

    
    public Course Course { get; set; }
}
