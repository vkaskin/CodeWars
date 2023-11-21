namespace CountingDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateCount("Indivisibility"));
            Console.ReadKey();
        }

        public static int DuplicateCount(string str)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (char.IsLetterOrDigit(c))
                {
                    char lowercaseChar = char.ToLowerInvariant(c);

                    if (charCount.ContainsKey(lowercaseChar))
                    {
                        charCount[lowercaseChar]++;
                    }
                    else
                    {
                        charCount[lowercaseChar] = 1;
                    }
                }
            }

            int duplicateCount = charCount.Count(pair => pair.Value > 1);

            return duplicateCount;
        }
    }
}
