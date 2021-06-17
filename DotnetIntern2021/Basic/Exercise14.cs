using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Basic
{
    public class Exercise14
    {
        public int Count(int n)
        {
            int count = 0;
            while (n >= 5)
            {
                n /= 5;
                count += n;
            }
            return count;
        }
    }
}
