using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai2
{
    public class Exercise11
    {
        public int SumOfPerfectSquares(List<int> data)
        {
            return data.Where(s => Math.Sqrt(s) % 1 == 0)
                       .Sum();
        }
    }
}
