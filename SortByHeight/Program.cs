namespace SortByHeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortByHeight(new int[] { -1, 150, 190, 170, -1, -1, 160, 180 }));
            Console.ReadKey();
        }

        public static int[] SortByHeight(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == -1)
                    continue;
                
                for (int j = i + 1; j < a.Length; j++)
                {
                    if ((a[i] > a[j]) && (a[j] != -1))
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            
            return a;
        }
    }
}

