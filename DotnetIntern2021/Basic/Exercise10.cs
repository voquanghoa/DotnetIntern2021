using System;

namespace DotnetIntern2021.Basic
{
    public class Exercise10
    {
        public double CubeRoot(double n)
        {
            double x = n;
            double root = x - (x*x*x - n) / (3 * x * x);

            while (Math.Abs(root - x) > 0.000001)
            {
                x = root;
                root = x - (x*x*x - n) / (3 * x * x);
            }
            return root;
        }

    }

}
