using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Basic
{
    public class Exercise18
    {
        public bool HappyNumber(int n)
        {
            var temp = n;
            while (true)
            {
                var sum = Convert(temp);
                if (sum < 10)
                {
                    return sum == 1 || sum == 7;

                }
                temp = sum;
            }
        }
        public int Convert(int temp)
        {
            var sum = 0;
            while (temp > 0)
            {
                sum += (temp % 10) * (temp % 10);

                temp /= 10;
            }
            return sum;
        }
    }
}
