using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai2
{
    public class Exercise9
    {
        public int SumEven(List<int> data)
        {
            return data.Where(s => s % 2 == 0)
                       .Sum();
        }
    }
}
