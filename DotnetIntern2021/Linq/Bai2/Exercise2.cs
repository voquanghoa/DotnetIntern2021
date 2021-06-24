using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai2
{
    public class Exercise2
    {
        public List<int> ThreeHighestValues(List<int> data)
        {
            return data.OrderByDescending(s => s)
                       .Distinct()
                       .Take(3)
                       .ToList();
        }
    }
}
