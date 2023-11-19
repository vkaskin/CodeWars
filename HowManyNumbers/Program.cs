using System.Numerics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HowManyNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SelNumber(200, 3));
            Console.ReadKey();
        }

        public static int SelNumber(int n, int d)
        {
            if (n < 12)
                return 0;

            int count = 0;

            for (int i = 12; i <= n; i++)
            {
                string str = i.ToString();

                char[] reversedChars = str.ToCharArray();

                Array.Reverse(reversedChars);

                int[] digits = reversedChars.Select(x => x - '0').ToArray();

                for (int j = 0; j < digits.Length - 1; j++)
                {
                    int diff = digits[j] - digits[j + 1];

                    if (diff <= 0 || diff > d)
                        break;

                    if (j == digits.Length - 2)
                        count++;
                }
            }
            return count;
        }
    }
}
