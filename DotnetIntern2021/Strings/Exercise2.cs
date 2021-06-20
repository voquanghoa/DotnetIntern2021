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
            string upperCase = "";
            upperCase += snakeCase[0].ToString().ToUpper();
            int i = 1;
            while(i < snakeCase.Length)
            {
                if (snakeCase[i] == '_')
                {
                    upperCase += snakeCase[i + 1].ToString().ToUpper();
                    i++;
                }
                else upperCase += snakeCase[i];
                i++;
            }

            return upperCase;
        }
    }
}
