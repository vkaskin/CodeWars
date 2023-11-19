namespace SumOfPrime_indexedEl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }));
            Console.ReadKey();
        }

        public static int Solve(int[] arr)
        {
            var primas = GetPrimesUpToLimit(arr.Length);

            int sum = 0;

            foreach (var item in primas) 
            {
                if (item < arr.Length)
                {
                    sum += arr[item];
                }
            }

            return sum;
        }

        static List<int> GetPrimesUpToLimit(int limit)
        {
            List<int> primes = new List<int>();

            for (int number = 2; number <= limit; number++)
            {
                if (IsPrime(number))
                {
                    primes.Add(number);
                }
            }

            return primes;
        }

        static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
