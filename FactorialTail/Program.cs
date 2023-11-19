using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FactorialTail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Zeroes(10, 20));
            Console.ReadKey();
        }

        public static int Zeroes(int radix, int number)
        {
            if (radix < 2 || number < 1)
            {
                // Обработка некорректных входных данных
                return 0;
            }

            Dictionary<int, int> factorizationMap = new();

            for (int i = 2; i * i <= radix; ++i)
            {
                if (radix % i == 0)
                {
                    int count = 0;
                    while (radix % i == 0)
                    {
                        radix /= i;
                        count++;
                    }
                    factorizationMap[i] = count;
                }
            }

            if (radix > 1)
                factorizationMap[radix] = 1;

            int minZeroes = int.MaxValue;

            foreach (var factor in factorizationMap)
            {
                int prime = factor.Key;
                int exponent = factor.Value;
                int zeroes = 0;
                int tempNumber = number;

                while (tempNumber >= prime)
                {
                    tempNumber /= prime;
                    zeroes += tempNumber;
                }

                minZeroes = Math.Min(minZeroes, zeroes / exponent);
            }

            return minZeroes;
        }
    }
}

