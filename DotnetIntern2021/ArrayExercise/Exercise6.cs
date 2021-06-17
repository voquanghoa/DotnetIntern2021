using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.ArrayExercise
{
    public class Exercise6
    {
        public int Search(int[] a, int x, int left, int right)
        {
            int n = a.Length;
            if (right >= left)
            {
                int middle = left + (right - left) / 2;
                if (a[middle] == x)
                    return 1;
                if (a[middle] > x)
                    return Search(a, x, left, middle - 1);
                return Search(a, x, middle + 1, right);
            }
            return -1;
        }
    }
}
