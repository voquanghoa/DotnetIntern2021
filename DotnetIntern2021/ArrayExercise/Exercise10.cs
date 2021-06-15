using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.ArrayExercise
{
    public class Exercise10
    {
        public int Ex10(int[] a)
        {
            int sum = 0;
            foreach(int item in a)
            {
                int root = Convert.ToInt32(Math.Sqrt(item));
                if (root * root == item) sum += item;
            }
            return sum;
        }
    }
}
