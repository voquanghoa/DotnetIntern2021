using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021
{
    public class Exercise11
    {
        public int reverse(int n)
        {
            String s = radixChange(n);
            int m = 0;
            int h = s.Length - 1;
            for (int i = 0; i <= h; i++)
            {
                if (s[i].CompareTo('1') == 0)
                {
                    m = m + Convert.ToInt32(Math.Pow(2, h - i));
                }
            }
            return m;
        }
        public string radixChange(int n)
        {
            String a = "";
            for (int i = 0; n > 0; i++)
            {
                a = a + (n % 2).ToString();
                n = n / 2;
            }
            int h = a.Length;
            return a;
        }
    }
}
