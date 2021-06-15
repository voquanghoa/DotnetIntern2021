using System;

namespace DotnetIntern2021.Basic
{
    public class Exercise9
    {
        public double SquareRoot(double n)
        {
            if (n == 0) return 0;
            if (n < 0) return -1;
            double x = n;
            double root = x - (x * x - n) / (2 * x); ;
            while (Math.Abs(root - x) >= 0.0001)
            {
                x = root;
                root = x - (x * x - n) / (2 * x);
            }
            return Math.Round(root, 4);
        }
    }

}
