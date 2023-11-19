using System.Text;

namespace ConvertStringToCamelCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mystr = Console.ReadLine();

            var result = ToCamelCase(mystr);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        public static string ToCamelCase(string str)
        {
            char[] separators = { '_', '-' };

            string[] substrings = str.Split(separators);

            StringBuilder sb = new StringBuilder();

            foreach (var substr in substrings)
            {
                if (!string.IsNullOrEmpty(substr))
                {
                    char[] chars = substr.ToCharArray();

                    if (sb.Length == 0)
                    {
                        sb.Append(chars);
                    }
                    else
                    {
                        chars[0] = char.ToUpper(chars[0]);
                        sb.Append(chars, 0, chars.Length);
                    }


                }
            }

            return sb.ToString();
        }


        //public static string ToCamelCase(string str)
        //{
        //    return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
        //}

        //public static string ToCamelCase(string str)
        //{
        //    return string.Concat(str.Split('-', '_').Select((s, i) => i > 0 ? char.ToUpper(s[0]) + s.Substring(1) : s));
        //}
    }
}