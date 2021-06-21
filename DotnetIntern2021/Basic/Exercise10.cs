using System;

namespace DotnetIntern2021.Basic
{
    public class Exercise10
    {
        public double CubeRoot(double n, double epsilon)
        {
            var x = n;
            var root = x - (x * x * x - n) / (3 * x * x);

            while (Math.Abs(root - x) > epsilon)
            {
                x = root;
                root = x - (x * x * x - n) / (3 * x * x);
            }
            return root;
        }

    }

}
