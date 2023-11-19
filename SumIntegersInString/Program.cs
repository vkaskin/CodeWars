namespace SumIntegersInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfIntegersInString("12.4"));
            Console.ReadKey();
        }

        public static int SumOfIntegersInString(string s)
        {
            var arr = s.ToArray();
            int sum = 0;
            int tempNumber;
            string str = "";

            foreach (var i in arr)
            {
                if (Char.IsDigit(i))
                {
                    str = str + i;
                }
                else
                {
                    if (int.TryParse(str, out tempNumber))
                    {
                        sum += tempNumber;
                        str = "";
                    }
                }
            }
            int.TryParse(str, out tempNumber);
            sum += tempNumber;            

            return sum;
        }
    }
}
