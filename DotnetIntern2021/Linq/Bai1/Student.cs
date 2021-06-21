using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai1
{
    public class Student
    {
        public Class Class { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public double Score { get; set; }

        public Student(
            Class @class,
            int id, 
            string name, 
            DateTime birthday, 
            double score)
        {
            Class = @class;
            Id = id;
            Name = name;
            Birthday = birthday;
            Score = score;
        }
    }
}
