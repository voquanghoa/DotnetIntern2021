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
            int max = 0;
            var answer = new List<int>();
            var temp = new List<int>();
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    if (temp.Count == 0)
                    {
                        temp.Add(arr[i - 1]);
                    }
                    temp.Add(arr[i]);
                }
                else
                {
                    if (max < temp.Count)
                    {
                        max = temp.Count;
                        answer = temp.ToList();
                    }
                    temp.Clear();
                }
            }
            return answer;
        }
    }
}
