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
            string ans = "";
            int i = 0;
            while (i < s.Length)
            {
                int count = 1;
                while (i < s.Length - 1 && s[i] == s[i + 1])
                {
                    i++;
                    count++;
                }
                if (count > 1)
                {
                    ans += s[i] + count.ToString();
                }
                else ans += s[i];
                i++;
            }
            Console.WriteLine(ans);
            return ans;
        }
    }
}
