using System.Collections.Generic;
using System.Linq;

namespace DetectiveInvestigations.Katas
{
    /// <summary>
    /// https://www.codewars.com/kata/john-and-ann-sign-up-for-codewars 
    /// </summary>
    public class Johnann
    {
        private static readonly Dictionary<long, long> As = new Dictionary<long, long> { { 0, 1 } };
        private static readonly Dictionary<long, long> Js = new Dictionary<long, long> { { 0, 0 } };

        private static long A(long n)
        {
            if (As.ContainsKey(n))
                return As[n];

            As.Add(n, n - J(As[n - 1]));
            return As[n];
        }

        private static long J(long n)
        {
            if (Js.ContainsKey(n))
                return Js[n];

            Js.Add(n, n - A(Js[n - 1]));
            return Js[n];
        }

        public static List<long> John(long n)
        {
            List<long> retval = new List<long>((int)n);

            for (long i = 0; i < n; i++)
                retval.Add(J(i));

            return retval;
        }

        public static List<long> Ann(long n)
        {
            List<long> retval = new List<long>((int)n);

            for (long i = 0; i < n; i++)
                retval.Add(A(i));

            return retval;
        }

        public static long SumJohn(long n) => John(n).Sum();
        public static long SumAnn(long n) => Ann(n).Sum();
    }
}
