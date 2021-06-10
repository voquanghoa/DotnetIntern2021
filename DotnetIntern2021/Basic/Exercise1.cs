using System;

namespace DotnetIntern2021.Basic
{
    public class Exercise1
    {
        public int UCLN(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            return a;
        }

        public int BCNN(int a, int b)
        {
            return a * b / UCLN(a, b);
        }
    }
}
