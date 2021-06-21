using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Basic
{
    public class Exercise17
    {
        private static int MAX = 1000000;
        private static bool[] checkPrime = InitEratosthenes();
        public int Ex17(int n)
        {
            for (var i = n + 1; true; i++)
            {
                if (checkPrime[i] && CheckPalindrome(i))
                {
                    return i;
                }
                i++;
            }
        }
        public static bool[] InitEratosthenes()
        {
            var checkPrime = new bool[MAX];
            for (int i = 2; i < MAX; i++)
            {
                checkPrime[i] = true;
            }
            for (int i = 2; i < MAX; i++)
            {
                if (checkPrime[i])
                {
                    for (int j = i * 2; j < MAX; j += i)
                    {
                        checkPrime[j] = false;
                    }
                }
            }

            return checkPrime;
        }
        public bool CheckPalindrome(int n)
        {
            int temp = n;
            int reverse = 0;
            while (temp != 0)
            {
                reverse = reverse * 10 + temp % 10;
                temp /= 10;
            }
            return reverse == n;
        }
    }
}
