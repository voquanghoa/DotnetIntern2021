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
            for (var i = 1; i <= s.Length; i++)
            {
                if (i % 2 == 0) sum += 3 * ((int)s[i - 1] - 48);
                else sum += ((int)s[i - 1] - 48);
            }
            return sum % 10 == 0;
        }
    }
}
