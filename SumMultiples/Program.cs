namespace SumMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumMul(123, 4567));
            Console.ReadKey();
        }

        public static int SumMul(int n, int m)
        {
            int sum = 0;

            if (n <= 0 || n > m)
                throw new System.ArgumentException();

            for (int i = n; i < m; i = i + n)
            {
                sum += i;
            }

            return sum;
        }

        //public static int SumMul(int n, int m)
        //{
        //    if (n <= 0 || n > m)
        //        throw new ArgumentException();

        //    return Enumerable.Range(n, m - n).Where(i => i % n == 0).Sum();
        //}
    }
}
