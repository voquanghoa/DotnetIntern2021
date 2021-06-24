using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai2
{
    public class Exercise3
    {
        public List<int> RandomNumbers(List<int> data, int n)
        {
            return data.OrderBy(data => Guid.NewGuid())
                       .Take(n)
                       .ToList();
        }
    }
}
