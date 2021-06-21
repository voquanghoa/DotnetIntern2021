using System;

namespace DotnetIntern2021.Basic
{
    public class Exercise7
    {
        public int GiaiThua(int n)
        {
            if (n == 0) return 1;
            return n * GiaiThua(n - 1);

        }
    }
}
