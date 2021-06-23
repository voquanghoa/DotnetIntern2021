using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai2
{
    public class Exercise4
    {
        public List<int> OrderByLastDigit(List<int>data)
        {
            return data.OrderBy(data => Math.Abs(data % 10))
                       .Select(data => data)
                       .ToList();
        }
    }
}
