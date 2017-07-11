using System;
using System.Text;

namespace DetectiveInvestigations.Katas
{
    /// <summary>
    /// https://www.codewars.com/kata/integers-recreation-one
    /// </summary>
    public static class IntegerRecreationOne
    {
        public static string listSquared(long m, long n)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("[");

            for (long num = m; num <= n; num++)
            {
                long sigma_2 = Sigma2(num);

                if (IsSquared(sigma_2))
                {
                    sb.Append($"[{num}, {sigma_2}], ");
                }
            }

            if (sb.Length - 2 > 0)
                sb.Length -= 2;

            sb.Append("]");

            return sb.ToString();
        }

        private static long Sigma2(long num)
        {
            if (num == 1)
                return 1;

            long result = 1 + num * num;

            for (long i = 2; i * i < num; i++)
            {
                if (num % i == 0)
                    result += i * i + (num / i) * (num / i);
            }

            return result;
        }

        private static bool IsSquared(long n)
        {
            return Math.Sqrt(n) % 1 == 0;
        }
    }
}
