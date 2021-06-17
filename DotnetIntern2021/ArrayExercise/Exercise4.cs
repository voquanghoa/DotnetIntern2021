using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetIntern2021.ArrayExercise
{
    public class Exercise4
    {
        private static int MAX = 1000000;
        private static bool[] checkPrime = InitEratosthenes();


        public int Ex4(int[] array)
        {
            int sum = 0;
            foreach (var number in array)
            {
                if (checkPrime[number]) sum += number;
            }

            return sum;
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
    }
}
