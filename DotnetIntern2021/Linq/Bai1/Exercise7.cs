using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai1
{
    public class Exercise7
    {
        private readonly DataFactory dataFactory = new();
        public List<double> FindAllScore()
        {
            return dataFactory.Students
                .Select(s => s.Score)
                .Distinct()
                .ToList();
        }
    }
}
