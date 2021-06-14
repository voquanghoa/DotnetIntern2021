using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.Basic
{
    public class Exercise17
    {
        static int MAX = 1000000;
        int[] checkPrime = new int[MAX + 2];
        public int Ex17(int n)
        {
            int answer = 0;
            Eratosthenes();
            int i = n + 1;
            while (true)
            {
                if (checkPrime[i] == 1 && CheckPalindrome(i))
                {
                    answer = i;
                    break;
                }
                i++;
            }
            return answer;
        }
        public void Eratosthenes()
        {
            for (int i = 2; i <= MAX; i++)
            {
                checkPrime[i] = 1;
            }
            for (int i = 2; i <= MAX; i++)
            {
                if (checkPrime[i] == 1)
                {
                    for (int j = i * 2; j <= MAX; j += i)
                    {
                        checkPrime[j] = 0;
                    }
                }
            }
        }
        public bool CheckPalindrome(int n)
        {
            int temp = n;
            int reverse = 0, rem;
            while (temp != 0)
            {
                rem = temp % 10;
                reverse = reverse * 10 + rem;
                temp /= 10;
            }
            if (reverse == n) return true;
            else return false;
        }
    }
}
