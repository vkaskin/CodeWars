namespace PrimeSextuplets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", FindPrimeSextuplet(29700000)));
            
            Console.ReadKey();
        }

        public static int[] FindPrimeSextuplet(long sumLimit)
        {
            
            List<int> sextuplet = new List<int>();
            int p = 2;

            while (true)
            {
                if (IsPrime(p))
                {
                    if (IsPrime(p + 4))
                    {
                        if (IsPrime(p + 6))
                        {
                            if (IsPrime(p + 10))
                            {
                                if (IsPrime(p + 12))
                                {
                                    if (IsPrime(p + 16))
                                    {
                                        long sum = p + (p + 4) + (p + 6) + (p + 10) + (p + 12) + (p + 16);

                                        if (sum > sumLimit)
                                        {
                                            Console.WriteLine("dassda");
                                            sextuplet = new List<int> { p, p + 4, p + 6, p + 10, p + 12, p + 16 };
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                p = GetNextPrime(p);

            }

            return sextuplet.ToArray();
        }

        static bool IsPrime(int number)
        {
            if (primeNumbers.Contains(number))
            {
                return true;
            }

            if (nonPrimeNumbers.Contains(number))
            {
                return false;
            }

            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    nonPrimeNumbers.Add(number);
                    return false;
                }
            }
            primeNumbers.Add(number);
            return true;
        }

        static int GetNextPrime(int current)
        {
            int next = current + 1;
            while (!IsPrime(next))
            {
                next++;
            }
            return next;
        }

        static HashSet<int> primeNumbers = new HashSet<int>();
        static HashSet<int> nonPrimeNumbers = new HashSet<int>();
    }
}