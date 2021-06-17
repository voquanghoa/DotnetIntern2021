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
            while (i >= 0 && fullName[i] != ' ')
            {
                i--;
            }

            return new List<string>
            {
                fullName.Substring(0, i),
                fullName.Substring(i + 1)
            };
        }

    }
}
