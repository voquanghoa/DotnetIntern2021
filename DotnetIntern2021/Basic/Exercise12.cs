using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Basic
{
    public class Exercise12
    {
        public int palindrome(int n)
        {
            string s = n.ToString();
            String temp = "";
            for (int i = s.Length - 1; i >=0; i--)
            {
                temp += s[i];
            }
            return Convert.ToInt32(temp);
        }
    }
}
