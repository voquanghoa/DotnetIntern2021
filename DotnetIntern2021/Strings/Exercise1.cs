using System;

namespace DotnetIntern2021.Strings
{
    public class Exercise1
    {
        public string snakeCase(String upperCase)
        {
            string snakeCase = "";
            for (int i = 0; i < upperCase.Length; i++)
            {
                if (upperCase[i] >= 'A' && upperCase[i] <= 'Z' && i != 0)
                    snakeCase += "_";
                snakeCase += upperCase[i];
            }
            return snakeCase.ToLower();
        }
    }
}
