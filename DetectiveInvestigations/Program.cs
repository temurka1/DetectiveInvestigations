using System;
using DetectiveInvestigations.Katas;

namespace DetectiveInvestigations
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int[] res = WNumbers.WeakNumbers(500);
            Console.WriteLine($"a = {res[0]}; b = {res[1]}");
            Console.ReadKey();
        }
    }
}
