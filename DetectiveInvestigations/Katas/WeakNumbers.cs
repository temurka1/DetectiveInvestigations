using System;
using System.Linq;

namespace DetectiveInvestigations.Katas
{
    /// <summary>
    /// https://www.codewars.com/kata/simple-fun-number-26-weak-numbers
    /// </summary>
    public static class WNumbers
    {
        public static int[] WeakNumbers(int n)
        {
            int[] divisors = new int[n];
            int[] weakness = new int[n];
            
            for (int i = 1; i <= n; i++)
                weakness[i - 1] = GetWeakness(i, divisors);
          
            Array.Sort(weakness);
            
            int maxWeak = weakness.Last();
            int count   = weakness.Where(t => t == maxWeak).Count();
            
            return new[] { maxWeak, count};
        }

        private static int GetWeakness(int n, int[] divisors)
        {
            int weakness  = 0;
            int ndivisors = GetDivisorsCount(n);

            for (int i = 1; i < n; i++)
            {
                if (divisors[i - 1] > ndivisors)
                    weakness++;
            }

            divisors[n - 1] = ndivisors;
            return weakness;
        }

        private static int GetDivisorsCount(int n)
        {
            int divisors = 2;

            for (int i = n / 2; i > 1; i--)
            {
                if (n % i == 0)
                    divisors++;
            }

            return divisors;
        }
    }
}