using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Strings
{
    public class Exercise5
    {
        public bool Palindrome(string s)
        {
            string left = "";
            string right = "";
            for (int i = s.Length/2 - 1; i>= 0 ; i--)
            {
                left += s[i];
                right += s[s.Length - i - 1];
            }
            return left == right;
        }
    }
}
