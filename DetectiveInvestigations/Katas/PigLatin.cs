using System;
using System.Linq;

namespace DetectiveInvestigations.Katas
{
    /// <summary>
    /// https://www.codewars.com/kata/simple-pig-latin/
    /// </summary>
    public class PigLatin
    {
        public static string PigIt(string str)
        {
            return String.Join(" ", str.Split(' ').Select(w => $"{w.Substring(1)}{w.Substring(0, 1)}ay"));
        }
    }
}