﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Won7L16.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Specialization Specialization { get; set; }
    }
}
