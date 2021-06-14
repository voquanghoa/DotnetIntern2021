using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.ArrayExercise
{
    public class Exercise5
    {
        public List<int> SubArray(int[] arr)
        {
            int n = arr.Length;
            int max = 0, len = 0;
            var answer = new List<int>();
            var temp = new List<int>();
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    if (len == 0)
                    {
                        temp.Add(arr[i - 1]);
                        len++;
                    }
                    temp.Add(arr[i]);
                    len++;
                }
                else
                {
                    if (max < len)
                    {
                        max = len;
                        answer.Clear();
                        answer = temp.ToList();
                    }
                    temp.Clear();
                    len = 0;
                }
            }
            return answer;
        }
    }
}
