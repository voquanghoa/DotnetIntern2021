using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai1
{
    public class Exercise8
    {
        private readonly DataFactory dataFactory = new();
        public List<string> ScoreLowerThanFive()
        {
            return dataFactory.Students
                .Where(s => s.Score < 5)
                .Select(s => s.Name)
                .ToList();
        }
    }
}