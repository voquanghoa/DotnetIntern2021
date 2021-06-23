using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Basic
{
    public class Exercise16
    {
        public bool checkPrime(int n)
        {
            var answer = new List<int>();
            int i = 2;
            while (n > 1)
            {
                if (n % i == 0) n = n / i;
                else i++;
                if (i > 5) return false;
            }
            return true;
        }
    }
}
