namespace FindTheOddInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindIt(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
            Console.ReadKey();
        }

        public static int FindIt(int[] seq)
        {
            Dictionary<int, int> counts = new();

            foreach (int i in seq) 
            {
                if(counts.ContainsKey(i))
                    counts[i]++;
                else
                    counts[i] = 1;
            }

            return counts.FirstOrDefault(x => x.Value % 2 != 0).Key;
        }
    }
}
