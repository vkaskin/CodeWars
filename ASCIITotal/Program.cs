namespace ASCIITotal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UniTotal("aaa"));
            Console.ReadLine();
        }

        public static int UniTotal(string str)
        {
            char[] chars = str.ToCharArray();

            int sum = 0;

            foreach (char c in chars)
            {
                sum += Convert.ToInt32(c);
            }
            return sum;
        }
    }
}
