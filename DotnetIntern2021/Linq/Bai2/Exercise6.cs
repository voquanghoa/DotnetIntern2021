using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai2
{
    public class Exercise6
    {
        public List<int> NoneRepeatedNumber(List<int> data)
        {
            return data.GroupBy(i => i)
                       .Where(g => g.Count() == 1)
                       .Select(g => g.Key)
                       .ToList();
        }
    }
}
