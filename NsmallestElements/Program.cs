namespace NsmallestElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result =FirstNSmallest(new[]  { 1, 2, 3, -4, 0 }, 3);
            Console.WriteLine(string.Join(", ", result));
            Console.ReadKey();
        }

        public static int[] FirstNSmallest(int[] arr, int n)
        {
            var smallestNumbers = arr.OrderBy(x => x).Take(n).ToArray();

            Dictionary<int, List<int>> indexMap = new Dictionary<int, List<int>>();

            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];

                if (!indexMap.ContainsKey(num))
                {
                    indexMap[num] = new List<int>();
                }

                indexMap[num].Add(i);
            }

            List<int> resultIndexes = new List<int>();

            for (int i = 0; i < smallestNumbers.Length; i++)
            {
                int num = smallestNumbers[i];

                if (indexMap.TryGetValue(num, out var indexes) && indexes.Count > 0)
                {
                    int index = indexes[0];
                    indexes.RemoveAt(0);

                    resultIndexes.Add(index);
                }
                else
                {
                    resultIndexes.Add(-1); // Если число не найдено, добавляем -1 в массив
                }
            }

            resultIndexes.Sort();
            
            var resultArray = resultIndexes
            .Where(index => index >= 0 && index < arr.Length)
            .Select(index => arr[index])
            .ToArray();

            return resultArray.ToArray();
        }

        //public static int[] FirstNSmallest(int[] arr, int n)
        //{
        //    var list = arr.ToList();

        //    while (list.Count > n)
        //    {
        //        int max = list.Max();

        //        int index = list.LastIndexOf(max);

        //        list.RemoveAt(index);
        //    }
        //    return list.ToArray();
        //}

        //public static int[] FirstNSmallest(int[] arr, int n)
        //{
        //    var smallestNumbers = arr.OrderBy(x => x).Take(n).ToList();
        //    return arr.Where(x => smallestNumbers.Remove(x)).ToArray();
        //}


    }
}