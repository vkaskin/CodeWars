namespace SexyPrimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SexyPrime(5, 11));
            Console.WriteLine(SexyPrime(61, 67));
            Console.WriteLine(SexyPrime(7, 13));
            Console.WriteLine(SexyPrime(5, 7));
            Console.WriteLine(SexyPrime(1, 7));

            Console.ReadKey();

        }

        public static bool SexyPrime(int x, int y)
        {
            if (x == 1 || y == 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }

            for (int i = 2; i <= Math.Sqrt(y); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }

            bool result = Math.Abs(x - y) == 6;

            return result;
        }
    }
}