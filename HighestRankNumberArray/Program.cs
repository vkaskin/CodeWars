namespace HighestRankNumberArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int HighestRank(int[] arr)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (int c in arr)
            {
                if (counts.ContainsKey(c))
                {
                    counts[c]++;
                }
                else
                {
                    counts[c] = 1;
                }
            }

            int maxMostFrequentKey = int.MinValue;
            int maxMostFrequentValue = 0;

            foreach (var kvp in counts)
            {
                if (kvp.Value > maxMostFrequentValue || (kvp.Value == maxMostFrequentValue && kvp.Key > maxMostFrequentKey))
                {
                    maxMostFrequentKey = kvp.Key;
                    maxMostFrequentValue = kvp.Value;
                }
            }

            return maxMostFrequentKey;
        }
    }
}
