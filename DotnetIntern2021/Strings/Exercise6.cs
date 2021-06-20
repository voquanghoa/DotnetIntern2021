using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Strings
{
    public class Exercise6
    {
        public string Ex6(string s)
        {
            StringBuilder ans = new StringBuilder();
            var i = 0;
            while (i < s.Length)
            {
                var count = 1;
                while (i < s.Length - 1 && s[i] == s[i + 1])
                {
                    i++;
                    count++;
                }
                if (count > 1)
                {
                    ans.Append(s[i] + count.ToString());
                }
                else ans.Append(s[i]);
                i++;
            }
            return ans.ToString();
        }
    }
}
