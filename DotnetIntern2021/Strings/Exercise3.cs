using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Strings
{
    public class Exercise3
    {
        public  string Reverse (string s)
        {
            string ans = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                ans += s[i];
            }
            return ans;
        }
    }
}
