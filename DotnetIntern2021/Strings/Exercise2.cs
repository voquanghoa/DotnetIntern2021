using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Strings
{
    public class Exercise2
    {
        public string Ex2(string snakeCase)
        {
            StringBuilder upperCase = new();
            upperCase.Append(char.ToUpper(snakeCase[0]));
            int i = 1;
            while(i < snakeCase.Length)
            {
                if (snakeCase[i] == '_')
                {
                    upperCase.Append(char.ToUpper(snakeCase[i + 1]));
                    i++;
                }
                else
                {
                    upperCase.Append(snakeCase[i]);
                }
                i++;
            }

            return upperCase.ToString();
        }
    }
}
