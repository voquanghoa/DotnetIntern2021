using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Basic
{
    public class Exercise15
    {
        public int findDigits(int n)
        {
            if (n < 0) return 0;

            if (n <= 1) return 1;

            double digits = 0;
            for (int i = 2; i <= n; i++)
            {
                digits += Math.Log10(i);
            }

            return (int)Math.Floor(digits) + 1;
        }
    }
}
