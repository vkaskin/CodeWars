using System.Text;

namespace DuplicateEncoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            var result = DuplicateEncode(str);

            Console.WriteLine(result);

            Console.ReadKey();
            Console.WriteLine();
        }

        //public static string DuplicateEncode(string word)
        //{
        //    StringBuilder sb = new();

        //    List<char> tempChars = new();

        //    char[] chars = word.ToLower().ToCharArray();

        //    bool isContains = false;

        //    for (int i = 0; i < chars.Length; i++)
        //    {
        //        if (tempChars.Contains(chars[i]))
        //        {
        //            sb.Append(')');
        //        }

        //        else
        //        {
        //            tempChars.Add(chars[i]);

        //            if (chars[i] == chars.Length)
        //            {
        //                sb.Append('(');
        //                break;
        //            }
        //            else
        //            {
        //                for (int j = i + 1; j < chars.Length; j++)
        //                {
        //                    if (chars[i] == chars[j])
        //                    {
        //                        isContains = true;
        //                        break;
        //                    }
        //                }
        //                if (isContains)
        //                {
        //                    sb.Append(')');
        //                    isContains = false;
        //                }

        //                else
        //                {
        //                    sb.Append('(');
        //                    isContains = false;
        //                }
        //            }
        //        }
        //    }

        //    return sb.ToString();
        //}

        //public static string DuplicateEncode(string word)
        //{
        //    return String.Concat(word.ToLower().Select(letter => word.ToLower().Where(x => x == letter).Count() == 1 ? "(" : ")"));
        //}

        static string DuplicateEncode(string input)
        {
            // Приведем все символы к нижнему регистру, чтобы игнорировать регистр при определении дубликатов
            input = input.ToLower();

            // Создадим словарь для отслеживания количества встреченных символов
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Пройдем по строке и заполним словарь
            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            // Пройдем по исходной строке и построим новую строку
            string result = "";
            foreach (char c in input)
            {
                // Если символ встречается более одного раза, добавим ')' в новую строку, иначе добавим '('
                result += (charCount[c] > 1) ? ')' : '(';
            }

            return result;
        }
    }
}