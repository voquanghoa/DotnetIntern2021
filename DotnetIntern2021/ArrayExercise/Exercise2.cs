using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.ArrayExercise
{
    public class Exercise2
    {
        public int Ex2(int[] a)
        {
            int n = a.Length;
            Array.Sort(a);
            return (a[n-1] + a[n-2] + a[n-3]);
        }
    }
}
