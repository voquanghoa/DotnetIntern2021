using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai1
{
    public class Exercise3
    {
        private readonly DataFactory dataFactory = new();
        public List<string> FindStudentByClass(string className)
        {
            return dataFactory.Students
                .Where(s => s.Class.Name
                .Equals(className))
                .Select(s => s.Name)
                .ToList();
        }
    }
}
