using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai2
{
    public class Exercise5
    {
        public int MostRepeatedNumber(List<int>data)
        {
            return data.GroupBy(i => i)
                       .OrderByDescending(g => g.Count())
                       .Select(g => g.Key)
                       .First();
        }
    }
}
