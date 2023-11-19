using System.Text;

namespace GiveMeDiamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size1 = 3;
            int size2 = 5;

            var test1 = print(size1);
            var test2 = print(size2);

            Console.WriteLine(test1);
            Console.WriteLine();
            Console.WriteLine(test2);

            Console.ReadKey();
        }

        //public static string PrintDiamond(int n)
        //{
        //    // Check if the input is even or negative
        //    if (n % 2 == 0 || n < 0)
        //    {
        //        return null;
        //    }

        //    // Initialize an empty string to store the diamond pattern
        //    string diamond = "";

        //    // Build the top half of the diamond
        //    for (int i = 0; i < n; i += 2)
        //    {
        //        string spaces = new string(' ', (n - i - 1) / 2);
        //        string stars = new string('*', i + 1);
        //        diamond += spaces + stars + "\n";
        //    }

        //    // Build the bottom half of the diamond (excluding the center line)
        //    for (int i = n - 2; i > 0; i -= 2)
        //    {
        //        string spaces = new string(' ', (n - i) / 2);
        //        string stars = new string('*', i);
        //        diamond += spaces + stars + "\n";
        //    }

        //    return diamond;
        //}

        public static string print(int n)
        {
            if (n % 2 == 0 || n < 0)
            {
                return null;
            }

            int middle = n / 2;
            StringBuilder sb = new StringBuilder();
            for (int index = 0; index < n; index++)
            {
                sb.Append(' ', Math.Abs(middle - index));
                sb.Append('*', n - Math.Abs(middle - index) * 2);
                sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}