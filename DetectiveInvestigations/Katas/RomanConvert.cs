using System.Collections.Generic;
using System.Text;

namespace DetectiveInvestigations.Katas
{
    /// <summary>
    /// https://www.codewars.com/kata/roman-numerals-encoder
    /// </summary>
    public static class RomanConvert
    {
        private static Dictionary<int, List<string>> table = new Dictionary<int, List<string>>
        {
            { 1,    new List<string> { "I", "V" } },
            { 10,   new List<string> { "X", "L" } },
            { 100,  new List<string> { "C", "D" } },
            { 1000, new List<string> { "M" } }
        };

        public static string Solution(int n)
        {
            StringBuilder retval = new StringBuilder();

            int tho = n / 1000;
            n -= tho * 1000;

            Append("M", retval, tho);

            for (int i = 100; i >= 1; i /= 10)
            {
                int t = n / i;
                n -= t * i;

                if (t <= 3)
                {
                    Append(table[i][0], retval, t);
                }
                else if (t == 4)
                {
                    retval.Append(table[i][0] + table[i][1]);
                }
                else if (t <= 8)
                {
                    retval.Append(table[i][1]);
                    Append(table[i][0], retval, t - 5);
                }
                else
                {
                    retval.Append(table[i][0] + table[i * 10][0]);
                }
            }

            return retval.ToString();
        }

        private static void Append(string str, StringBuilder sb, int count)
        {
            for (int i = 0; i < count; i++)
                sb.Append(str);
        }
    }
}
