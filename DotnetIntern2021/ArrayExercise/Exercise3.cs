using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.ArrayExercise
{
    public class Exercise3
    {
        public int Ex3(int[] a)
        {
            int n = a.Length;
            int odd = 0, even = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0) even += a[i];
                else odd += a[i];
            }
            return even - odd;
        }
    }
}
