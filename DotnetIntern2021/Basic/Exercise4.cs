using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Basic
{
    public class Exercise4
    {
        public List<int> Fibo(int n)
        {
            var result = new List<int>();
            if (n == 1)
            {
                result.Add(1);
                return result;
            }
            int f0 = 1;
            int f1 = 1;
            int current = 1;
            
            while (S < n)
            {
                result.Add(current);
                current = f0 + f1;
                f0 = f1;
                f1 = current;
            }
            return result;
        }
    }
}
