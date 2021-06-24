using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai2
{
    public class Exercise12
    {
        public int CountNumberOfPrimes(List<int> data)
        {
            return data.Where(data => data >= 2 &&
                             Enumerable.Range(2, (int)Math.Sqrt(data))
                             .All(divisor => data % divisor != 0))
                        .ToList()
                        .Count;
        }
    }
}
