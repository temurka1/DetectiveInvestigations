using System;
using DetectiveInvestigations.Katas;
using System.Diagnostics;
using System.Linq;

namespace DetectiveInvestigations
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int[] res = CWeakNumbers.WeakNumbers(500);
            Console.WriteLine($"a = {res[0]}; b = {res[1]}");
            Console.ReadKey();
        }
    }
}
