namespace DetectiveInvestigations.Katas
{
    /// <summary>
    /// https://www.codewars.com/kata/greed-is-good
    /// </summary>
    public static class GreedIsGood
    {
        public static int Score(int[] dice)
        {
            int[] bucket = new int[6] { 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < dice.Length; i++)
                bucket[dice[i] - 1]++;

            return 1000 * (bucket[0] / 3) + 100 * (bucket[0] % 3) +
                   200  * (bucket[1] / 3) +
                   300  * (bucket[2] / 3) +
                   400  * (bucket[3] / 3) +
                   500  * (bucket[4] / 3) + 50 * (bucket[4] % 3) +
                   600  * (bucket[5] / 3);
        }
    }
}
