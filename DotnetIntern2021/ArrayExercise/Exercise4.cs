using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.ArrayExercise
{
    public class Exercise4
    {
        static int MAX = 1000000;
        int[] checkPrime = new int[MAX + 2];
        public int Ex4(int[] a)
        {
            int sum = 0;
            Eratosthenes();
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i].ToString() + ": " +  checkPrime[a[i]].ToString());
                if (checkPrime[a[i]] == 1) sum += a[i];
            }
            return sum;
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
    }
}
