namespace RequiredData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSel(new[] { -3, -2, -1, 3, 4, -5, -5, 5, -1, -5 }));
            Console.ReadKey();
        }

        public static object[] CountSel(int[] lst)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (int i in lst)
            {
                if (dic.ContainsKey(i))
                    dic[i]++;
                else
                    dic.Add(i, 1);
            }
            int totalAmount = lst.Length;
            int differentValues = dic.Count;
            int uniqueNumbers = dic.Where(x => x.Value == 1).Count();
            int maxValue = dic.Max(x => x.Value);
            int[] occurrences = dic.Where(x => x.Value == maxValue).Select(kv => kv.Key).OrderBy(x => x).ToArray();

            return new object[] { totalAmount, differentValues, uniqueNumbers, new object[] { occurrences, maxValue } };
        }
    }
}
