using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai1
{
    public class Exercise14
    {
        private readonly DataFactory dataFactory = new();
        public List<string> OrderStudentsByName(string className)
        {
            return dataFactory.Students
                .Where(s => s.Class.Name.Equals(className))
                .OrderBy(s => s.Name.Split(" ").Last())
                .ThenBy(s => s.Name.Split(" ").First())
                .Select(s => s.Name)
                .ToList();
        }
    }
}
