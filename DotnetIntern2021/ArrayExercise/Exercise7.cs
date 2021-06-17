using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.ArrayExercise
{
    public class Exercise7
    {
        public List<int[]> SubArray(int[] a, int m)
        {
            var answer = new List<int[]>();
            int j = 0;
            int n = a.Length;
            while (n > 0)
            {
                if (n < m) m = n;
                int[] temp = new int[m];
                for (int i = 0; i < m; i++)
                {
                    temp[i] = a[j];
                    j++;
                }
                n -= m;
                answer.Add(temp);
            }
            return answer;
        }
    }
}
