using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Strings
{
    public class Exercise7
    {
        public string Ex7(string s)
        {
            var stringBuilder = new StringBuilder();
            var lastCharacter = '0';
            var count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    count = count * 10 + (s[i] - '0');
                }
                else
                {
                    for (var j = 0; j < count - 1; j++)
                    {
                        stringBuilder.Append(lastCharacter);
                    }

                    lastCharacter = s[i];
                    stringBuilder.Append(s[i]);
                    count = 0;
                }
            }

            for (var j = 0; j < count - 1; j++)
            {
                stringBuilder.Append(lastCharacter);
            }

            return stringBuilder.ToString();
        }
    }
}
