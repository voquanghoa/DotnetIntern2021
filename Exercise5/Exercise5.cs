using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021
{
    public class Exercise5
    {
        public List<int> bai5(int m)
        {
            var a = new List<int>();
            int[] temp = new int[3];
            int[] answer = new int[m];
            for (int i = 10; i < m; i++)
            {
                int sum = sumCS(i);
                if (sum == i) a.Add(i);
            }
            return a;
        }
        public int sumCS(int a)
        {
            int answer = 0;
            int temp = a;
            int length = 0;
            while (temp > 0)
            {
                temp = temp / 10;
                length++;
            }
            while (a > 0)
            {
                answer += pow(a % 10, length);
                a /= 10;
            }
            return answer;
        }
        public int pow(int n, int m)
        {
            int ans = 1;
            for (int i = 1; i <= m; i++) ans *= n;
            return ans;
        }
    }


}
