
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Basic
{
    public class Exercise11
    {
        public int Reverse(int n)
        {
            var result = 0;
            while (n > 0)
            {
                result = (result << 1) | (n & 1);
                n >>= 1;
            }
            return result;
        }
    }
}
