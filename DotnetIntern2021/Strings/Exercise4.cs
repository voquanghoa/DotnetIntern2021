using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DotnetIntern2021.Strings
{
    public class Exercise4
    {
        public int SumEx4(string s)
        {
            var tempNumber = 0;
            var sum1 = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    tempNumber = tempNumber * 10 + (s[i] - '0');
                }
                else
                {
                    sum1 += tempNumber;
                    tempNumber = 0;
                }
            }
            return sum1 + tempNumber;
        }
    }
}
