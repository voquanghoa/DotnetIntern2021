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
            int temp = n;
            while (true)
            {
                int sum = 0;
                while (temp > 0)
                {
                    sum += (temp % 10) * (temp % 10);

                    temp /= 10;
                }
                if (sum < 10)
                {
                    if (sum == 1 || sum == 7) return true;
                    else return false;
                }
                temp = sum;
            }
        }
    }
}
