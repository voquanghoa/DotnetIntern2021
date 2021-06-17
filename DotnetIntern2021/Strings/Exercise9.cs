using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Strings
{
    public class Exercise9
    {
        public bool BarcodeEAN(string s)
        {
            var sum = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += 3 * (s[i] - '0');
                }
                else
                {
                    sum += s[i] - '0';
                }
            }
            return sum % 10 == 0;
        }
    }
}
