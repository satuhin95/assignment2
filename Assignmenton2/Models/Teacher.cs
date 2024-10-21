﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignmenton2.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}