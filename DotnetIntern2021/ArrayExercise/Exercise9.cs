using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.ArrayExercise
{
    public class Exercise9
    {
        public List<int> Ex9(int m, int n)
        {
            var answer = new List<int>();
            Random random = new();
            while (answer.Count < n)
            {
                int temp = random.Next(1, m);
                if (binarySearch(answer, temp, 0, answer.Count - 1) == -1)
                {
                    answer.Add(temp);
                }
                answer.Sort();
            }
            return answer;
        }
        public int binarySearch(List<int> a, int x, int left, int right)
        {
            if (right >= left)
            {
                int middle = left + (right - left) / 2;
                if (a[middle] == x)
                    return 1;
                if (a[middle] > x)
                    return binarySearch(a, x, left, middle - 1);
                return binarySearch(a, x, middle + 1, right);
            }
            return -1;
        }
    }
}
