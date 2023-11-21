namespace SortArayByValueAndIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortByValueAndIndex(new int[] { 23, 2, 3, 4, 5 }));
            Console.ReadKey();
        }

        public static int[] SortByValueAndIndex(int[] array)
        {
            int n = array.Length;

            // Создаем массив, в котором каждый элемент - это пара из произведения значения на индекс и оригинального индекса
            int[][] elementProducts = new int[n][];
            for (int i = 0; i < n; i++)
            {
                elementProducts[i] = new int[] { array[i] * (i + 1), i };
            }

            // Сортируем массив по произведениям
            Array.Sort(elementProducts, (x, y) => x[0].CompareTo(y[0]));

            // Создаем новый массив с отсортированными значениями
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = array[elementProducts[i][1]];
            }

            return result;
        }
    }
}
