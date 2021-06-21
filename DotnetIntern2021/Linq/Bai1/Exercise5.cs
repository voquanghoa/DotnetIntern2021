using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai1
{
    public class Exercise5
    {
        private readonly DataFactory dataFactory = new();
        public List<string> MaxScoreGroupByClass()
        {
            return dataFactory.Students
                .AsEnumerable()
                .GroupBy(s => s.Class.Name)
                .Select(g => 
                        g.OrderByDescending(s => s.Score)
                        .First()
                        .Name)
                .ToList();
        }
    }
}
