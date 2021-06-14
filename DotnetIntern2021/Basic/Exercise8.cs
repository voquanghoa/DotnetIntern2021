using System;
namespace DotnetIntern2021.Basic
{
    public class Exercise8
    {
        public double Pi()
        {
            int i = 3;
            double s = 0;
            int check = 1;
            while (i <= 5000)
            {
                s = s + Math.Pow(-1, check) * (Math.Pow(i, -1));
                if (check == 1) check = 2;
                else check = 1;
                i += 2;
            }
            return Math.Round((1 + s) * 4, 4);
        }
    }

}
