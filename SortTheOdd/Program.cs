namespace SortTheOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
            Console.ReadKey();
        }

        public static int[] SortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] % 2 != 0 && array[j] < array[minIndex])
                        {
                            minIndex = j;
                        }
                    }
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }

            return array;
        }
    }
}
