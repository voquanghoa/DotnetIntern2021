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
            for (var i = 0; i <= s.Length / 2 - 1; i++)
            {
                if (s[i] != s[s.Length - i - 1]) return false;
            }
            return true;
        }
    }
}
