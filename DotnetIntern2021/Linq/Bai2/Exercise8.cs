using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai2
{
    public class Exercise8
    {
        public List<int> OrderByNumberOfDigits(List<int> data)
        {
            return data.OrderBy(data => Math.Floor(Math.Log10(data) + 1))
                       .ThenBy(data => data)
                       .ToList();
        }
    }
}
