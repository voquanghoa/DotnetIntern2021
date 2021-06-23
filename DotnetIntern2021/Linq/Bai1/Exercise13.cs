using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai1
{
    public class Exercise13
    {
        private readonly DataFactory dataFactory = new();
        public bool CheckStudent(int year, double score)
        {
            return dataFactory.Students
                  .Any(s => s.Class.Name.Equals("Class A")
                            && s.Birthday.Year == year
                            && s.Score >= score);
        }
    }
}
