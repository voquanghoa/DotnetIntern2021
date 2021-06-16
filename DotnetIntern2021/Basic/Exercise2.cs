using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Basic
{
    public class Exercise2
    {
        public int SumCS(int a)
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
