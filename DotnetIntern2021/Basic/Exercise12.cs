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
            int temp = n;
            int reverse = 0, rem;
            while (temp != 0)
            {
                rem = temp % 10;
                reverse = reverse * 10 + rem;
                temp /= 10;
            }
            return reverse;
        }
    }
}
