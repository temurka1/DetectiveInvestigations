using System;

namespace DetectiveInvestigations.Katas
{
    /// <summary>
    /// https://www.codewars.com/kata/55db7b239a11ac71d600009d
    /// </summary>
    public static class IntegerTriangles
    {
        public static int GiveTriang(int per)
        {
            // https://en.wikipedia.org/wiki/Integer_triangle

            // a = m^2 - m * n + n^2
            // b = 2 * m * n - n^2
            // c = m^2 - n^2

            // 0 < n < m, m != n mod 3

            // p = 2 * m^2 - n^2 + m * n, p <= per
            return 0;
        }
    }
}
