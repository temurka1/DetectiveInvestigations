namespace DetectiveInvestigations.Katas
{
    /// <summary>
    /// https://www.codewars.com/kata/bit-calculator
    /// </summary>
    public static class BitCalculator
    {
        public static int Calculate(string num1, string num2)
        {
            return BinToDec(num1) + BinToDec(num2);
        }

        private static int BinToDec(string num)
        {
            int retval = 0;
            for (int i = 0; i < num.Length; i++)
                retval += (num[i] - '0') * pow(2, num.Length - i - 1);

            return retval;
        }

        private static int pow(int num, int power)
        {
            int retval = 1;
            for (int i = 0; i < power; i++)
                retval *= num;

            return retval;
        }
    }
}
