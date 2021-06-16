using System;

namespace DotnetIntern2021.Basic
{
    public class Exercise9
    {
        public double SquareRoot(double n, double epsilon)
        {
            if (n == 0) return 0;
            if (n < 0) return -1;
            var x = n;
            var root = x - (x * x - n) / (2 * x); ;
            while (Math.Abs(root - x) >= epsilon)
            {
                x = root;
                root = x - (x * x - n) / (2 * x);
            }
            return root;
        }
    }

}
