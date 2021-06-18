﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai1
{
    class DataFactory
    {
        public readonly List<Class> Class = new()
        {
            new Class() { Id = 1, Name = "Class A" },
            new Class() { Id = 2, Name = "Class B" }
        };
        public readonly List<Student> Students = new List<Student>()
        {
            new Student(new Class() { Id = 1, Name = "Class A" }, 1, "John", new DateTime(2000, 2, 1), 9.0),
            new Student(new Class() { Id = 2, Name = "Class B" }, 2, "David", new DateTime(2000, 7, 8), 9.5),
            new Student(new Class() { Id = 1, Name = "Class A" }, 3, "Black Pink", new DateTime(1996, 12, 4), 8.0),
            new Student(new Class() { Id = 2, Name = "Class B" }, 4, "Hyun Bin", new DateTime(1980, 5, 15), 10.0)
        };
    }
}