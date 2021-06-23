using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai1
{
    public class Exercise10
    {
        private readonly DataFactory dataFactory = new();
        public List<int[]> CountScoreHigherThanEight()
        {
            return dataFactory.Students
                .GroupBy(s => s.Class.Name)
                .Select(group => new[] { group.Count(), group.Count(s => s.Score > 8.0) })
                .ToList();
        }
    }
}