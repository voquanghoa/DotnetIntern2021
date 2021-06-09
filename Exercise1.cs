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
            int temp1 = a, temp2 = b;
            while (temp1 != temp2)
            {
                if (temp1 > temp2) temp1 = temp1 - temp2;
                else temp2 = temp2 - temp1;
            }
            return (a * b) / temp2;
        }
    }
}
