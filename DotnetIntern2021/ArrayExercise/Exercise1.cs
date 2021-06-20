using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.ArrayExercise
{
    public class Exercise1
    {
        public List<int> Ex1(int[] a)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                if (dict.ContainsKey(a[i])) 
                {
                    dict[a[i]]++;
                }
                else 
                {
                    dict.Add(a[i], 1);
                }
            }

            List<int> answer = new();
            foreach (KeyValuePair<int, int> item in dict)
            {
                if (item.Value > 1) answer.Add(item.Key);
            }
            return answer;
        }
    }
}
