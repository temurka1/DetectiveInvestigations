using System;
using System.Collections.Generic;
using System.Linq;

namespace DetectiveInvestigations.Katas
{
    /// <summary>
    /// https://www.codewars.com/kata/getting-along-with-integer-partitions
    /// </summary>
    public static class IntegerPartitions
    {
        public static string Part(long n)
        {
            List<int> prod = GetMimic((int)n);
            return $"Range: {prod.Last() - 1} Average: {prod.Average():0.00} Median: {((double)(prod.ElementAt(prod.Count() / 2) + prod.ElementAt((prod.Count() - 1) / 2))) / 2:0.00}";
        }

        private static List<int> GetMimic(int num)
        {
            List<int> primes = Enumerable.Range(2, Int32.MaxValue - 1).Where(n => Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(divisor => n % divisor != 0)).TakeWhile(p => p <= num).ToList();
            List<int> mimic = new List<int>();

            if (num > 1)
                mimic.Add(1);

            foreach (int prime in primes)
            {
                mimic.Add(prime);
                AddMimic(primes, mimic, prime, prime, num - prime);
            }

            mimic.Sort();
            return mimic;
        }

        private static void AddMimic(List<int> primes, List<int> mimic, int add, int from, int to)
        {
            foreach (int step in primes.Where(p => p >= from && p <= to))
            {
                int cur = add * step;
                mimic.Add(cur);

                if (step * 2 <= to)
                    AddMimic(primes, mimic, cur, step, to - step);
            }
        }
    }
}
