using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Basic
{
    public class Exercise3
    {
        public string prime(int n)
        {
            string answer = "";
            int i = 2;
            while (n > 1)
            {
                if (n % i == 0)
                {
                    answer = answer + "*" + i.ToString();
                    n = n / i;
                }
                else
                {
                    i++;
                }
            }
            answer = answer.Remove(0,1);
            return answer;
        }
    }

}
