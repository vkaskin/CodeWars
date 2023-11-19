namespace Interbals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumIntervals(new [] { (1, 5), (1, 6), (5, 11), (10, 20), (16, 19) }));
            
            Console.ReadKey();
        }

        public static int SumIntervals((int, int)[] intervals)
        {
            int start = int.MinValue;
            int end = int.MinValue;
            int sum = 0;

            for (int i = 0; i < intervals.Length; i++)
            {
                var minTuple = intervals
                .GroupBy(t => t.Item1)
                .OrderBy(g => g.Key)
                .Skip(i)
                .Select(g => g.OrderByDescending(t => t.Item2).First())
                .FirstOrDefault();

                Console.WriteLine($"Кортеж с минимальным значением Item1 и Item2: ({minTuple.Item1}, {minTuple.Item2})");

                if (minTuple.Item1 > start)
                    start = minTuple.Item1;

                if (minTuple.Item1 < end)
                    start = end;

                if (minTuple.Item2 > end)
                {
                    end = minTuple.Item2;
                    sum = sum + (end - start);
                    start = end;
                }


            }
            return sum;
        }




    }
}