namespace ClosestToZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Closest(new int[] { 2, 4, -1, -3 }));
            Console.ReadKey();
        }

        public static int? Closest(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return null;
            }

            int? closest = arr[0];
            bool hasDuplicate = false;

            for (int i = 1; i < arr.Length; i++)
            {
                int num = arr[i];

                if (num == 0)
                {
                    return 0;
                }

                if (Math.Abs(num) < Math.Abs(closest.Value))
                {
                    closest = num;
                    hasDuplicate = false;
                }
                else if (Math.Abs(num) == Math.Abs(closest.Value) && num != closest)
                {
                    hasDuplicate = true;
                }
            }

            if (hasDuplicate)
            {
                return null;
            }

            return closest;
        }
    }
}
