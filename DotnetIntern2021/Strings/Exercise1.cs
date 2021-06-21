using System;
using System.Text;

namespace DotnetIntern2021.Strings
{
    public class Exercise1
    {
        public string snakeCase(String upperCase)
        {
            StringBuilder snakeCase = new StringBuilder("");
            for (int i = 0; i < upperCase.Length; i++)
            {
                if (upperCase[i] >= 'A' && upperCase[i] <= 'Z' && i != 0)
                    snakeCase.Append("_");
                snakeCase.Append(upperCase[i]);
            }
            return snakeCase.ToString().ToLower();
        }
    }
}
