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
            var result = new List<string>();
            var groupedResult = dataFactory.Students.GroupBy(s => s.Class.Name);
            foreach (var ageGroup in groupedResult)
            {
                var x = ageGroup.OrderByDescending(s => s.Score).First().Name;
                result.Add(x);
            }
            return result;
        }
    }
}
