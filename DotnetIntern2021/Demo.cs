using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021
{
    public class Demo
    {
        public int Sum(int a, int b) => a + b;

        public int Substract(int a, int b) => a - b;

        public int Max(int a, int b, int c)
        {
            if(a > b && a > c)
            {
                return a;
            }

            if(b > c)
            {
                return b;
            }

            return c;
        }
    }
}
