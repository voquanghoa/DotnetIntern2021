using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Strings
{
    public class Exercise10
    {
        public List<string> SeparateFullName(string fullName)
        {
            int i = fullName.Length - 1;
            while (fullName[i] != ' ')
            {
                i--;
            }
            var answer = new List<string>();
            answer.Add(fullName.Substring(0, i));
            answer.Add(fullName.Substring(i + 1, fullName.Length - i - 1));
            return answer;
        }

    }
}
