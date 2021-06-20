using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DotnetIntern2021.Strings
{
    public class Exercise4
    {
        public int SumEx4(string s)
        {
            int sum = 0;
            string tempString = "";
            int i = 0;
            while (i < s.Length)
            {
                if (char.IsDigit(s[i]))
                {
                    tempString += s[i];
                }
                else
                {
                    if (tempString != "") sum += Convert.ToInt32(tempString);
                    tempString = "";
                }
                i++;
            }
            if (!string.Equals(tempString, "")) sum += Convert.ToInt32(tempString);
            return sum;
        }
    }
}
