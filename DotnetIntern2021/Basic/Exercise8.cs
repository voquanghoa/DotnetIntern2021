using System;
namespace DotnetIntern2021.Basic
{
    public class Exercise8
    {
        public double Pi()
        {
            double i = 3;
            double s = 0;
            int check = 1;
            while (4 / (2 * i + 1) >= 0.00001)
            {
                if (check % 2 == 0)
                    s += Math.Pow(i, -1);
                else 
                    s -= Math.Pow(i, -1);
                check++;
                i += 2;
            }
            return (1 + s) * 4;
        }
    }

}
