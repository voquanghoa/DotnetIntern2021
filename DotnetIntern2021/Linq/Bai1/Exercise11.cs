using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai1
{
    public class Exercise11
    {
        private readonly DataFactory dataFactory = new();
        public string FindStudentContainsName()
        {
            return dataFactory.Students
                .GroupBy(s => s.Class.Name)
                .OrderByDescending(group => group.Average(s => s.Score))
                .First()
                .Key
                ;
        }
    }
}
