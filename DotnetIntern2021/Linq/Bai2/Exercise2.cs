using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Linq.Bai2
{
    public class Exercise2
    {
        private List<int> data = new List<int>
        {
            1, 2, 3, 4, 5, 6, 7, -7, -6, -5, -4, -3, -2, -1
        };
        public List<int> ThreeHighestIndexNumbers()
        {
            return data.TakeLast(3).ToList();
        }
    }
}
