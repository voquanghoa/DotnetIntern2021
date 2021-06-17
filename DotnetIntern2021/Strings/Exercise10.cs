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
            int lastSpaceIndex = fullName.LastIndexOf(' ');

            return new List<string>
            {
                fullName.Substring(0, lastSpaceIndex),
                fullName.Substring(lastSpaceIndex + 1)
            };
        }

    }
}
