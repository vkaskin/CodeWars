namespace NumbersWithThisDigitInside
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumbersWithDigitInside(44, 4));
            Console.ReadKey();
        }

        public static long[] NumbersWithDigitInside(long x, long d)
        {

            var matchingNumbers = Enumerable.Range(1, (int)x)
                                        .Where(num => num.ToString().Contains(d.ToString()));

            long count = matchingNumbers.Count();
            long sum = matchingNumbers.Sum();
            long product = count > 0 ? matchingNumbers.Aggregate((long)1, (acc, num) => acc * num) : 0;

            return new long[] { count, sum, product };
        }
    }
}
