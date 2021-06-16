using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Basic
{
    public class Exercise5
    {
        public List<int> Bai5(int m)
        {
            var result = new List<int>();
            for (var i = 10; i < m; i++)
            {
                var sum = SumCS(i);
                if (sum == i) result.Add(i);
            }
            return result;
        }
        public int SumCS(int a)
        {
            var answer = 0;
            var temp = a;
            var length = 0;
            while (temp > 0)
            {
                temp = temp / 10;
                length++;
            }
            while (a > 0)
            {
                answer += Pow(a % 10, length);
                a /= 10;
            }
            return answer;
        }
        public int Pow(int n, int m)
        {
            var ans = 1;
            for (var i = 1; i <= m; i++) ans *= n;
            return ans;
        }
    }


}
