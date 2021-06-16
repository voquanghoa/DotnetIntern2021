using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.ArrayExercise
{
    public class Exercise8
    {
        public int Count(int[] a)
        {
            int n = a.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 3 == 0 && a[i] % 5 != 0) count++;
            }
            return count;
        }
    }
}
