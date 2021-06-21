using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai1
{
    public class Exercise6
    {
        private readonly DataFactory dataFactory = new();
        public List<string> FindStudentContainsXname(string x){
            return dataFactory.Students
                .Where(s => s.Name.Contains(x))
                .Select(s => s.Name)
                .ToList();
        }
    }
}
