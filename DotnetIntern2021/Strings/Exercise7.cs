using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Strings
{
    public class Exercise7
    {
        public string Ex7(string s)
        {
            string ans = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] < '1' || s[i] > '9') ans += s[i];
                else
                {
                    for (int j = 0; j < Convert.ToInt32(s[i].ToString()) - 1; j++) 
                        ans += s[i - 1];
                }
            }
            return ans;
        }
    }
}
