using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021
{
    public class Exercise4
    {
        public List<int> fibo(int n)
        {
            var a = new  List<int>();
            if (n == 1)
            {
                a.Add(1);
                return a;
            }
            int f0 = 1;
            int f1 = 1;
            int S = 1;
            
            while (S < n)
            {
                a.Add(S);
                S = f0 + f1;
                f0 = f1;
                f1 = S;
            }
            return a;
        }
    }
}
