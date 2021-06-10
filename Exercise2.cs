using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021
{
    public class Exercise2
    {
        public int sumCS(int a)
        {
            int answer = 0;
            while (a > 0)
            {
                answer += a % 10;
                a = a / 10;
            }
            return answer;
        }
    }
}
