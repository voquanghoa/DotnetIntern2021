using System;

namespace ExerciseBasic
{
    class Exercise1
    {
        public int UCLN(int a, int b)
        {
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }
        public int BCNN(int a, int b)
        {
            return (a * b) / UCLN(a,b);
        }
    }
}
