using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai1
{
    public class Exercise1
    {
        private static DataFactory dataFactory = new();
        public double Score(int studentId)
        {
            return dataFactory.Students.Where(s => s.Id == studentId)
                  .Select(s => s.Score).First();
        }
    }
}
