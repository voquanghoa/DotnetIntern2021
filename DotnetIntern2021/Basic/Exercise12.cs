using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Basic
{
    public class Exercise12
    {
        public int Palindrome(int n)
        {
            var temp = n;
            var reverse = 0;
            while (temp != 0)
            {
                reverse = reverse * 10 + temp % 10;
                temp /= 10;
            }
            return reverse;
        }
    }
}
