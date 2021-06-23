using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai1
{
    public class Exercise12
    {
        private readonly DataFactory dataFactory = new DataFactory();
        public int RandomFiveStudentByClass(string className)
        {
            return dataFactory.Students
                               .Where(s => s.Class.Name.Equals(className))
                               .Select(s => s.Name)
                               .Take(5)
                               .ToList()
                               .Count;
        }
    }
}
