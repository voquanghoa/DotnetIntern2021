using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Strings
{
    public class Exercise8
    {
        public string Ex8(string s)
        {
            var i = 0;
            while (i < s.Length)
            {
                var j = i;
                while (i < s.Length - 1 && s[i] == s[i + 1])
                    i++;
                s = s.Remove(j, i - j);
                i = j + 1;
            }
            return s;
        }
    }
}