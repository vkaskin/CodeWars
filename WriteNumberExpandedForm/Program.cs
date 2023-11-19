using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WriteNumberExpandedForm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ExpandedForm(70304));
            Console.ReadKey();
            
        }

        public static string ExpandedForm(long num)
        {
            StringBuilder sb = new StringBuilder();
            
            int[] digits = num.ToString().Select(c => int.Parse(c.ToString())).ToArray();
            
            int exponent = digits.Length-1;
            
            for (int i = 0; i < digits.Length; i++)
            {
                double sum = digits[i] * Math.Pow(10, exponent);
                if (sum > 0)
                {
                    sb.Append(sum.ToString());
                    sb.Append(" + ");
                }
                exponent--;
            }
            return sb.Remove(sb.Length - 3, 3).ToString();
        }
    }
}
