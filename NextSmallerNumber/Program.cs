namespace NextSmallerNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NextSmaller(531));
            Console.ReadKey();
        }

        public static long NextSmaller(long n)
        {
            char[] digits = n.ToString().ToCharArray();
            int i, j;

            // Находим первую пару соседних цифр, где левая цифра меньше правой
            for (i = digits.Length - 1; i > 0; i--)
            {
                if (digits[i - 1] > digits[i])
                    break;
            }

            // Если не найдено, то число уже самое маленькое
            if (i == 0)
                return -1;

            // Находим самую большую цифру справа от позиции i, которая меньше цифры в позиции i
            for (j = digits.Length - 1; j >= i; j--)
            {
                if (digits[j] < digits[i - 1])
                    break;
            }

            // Меняем местами цифры в позициях i и j
            char temp = digits[i - 1];
            digits[i - 1] = digits[j];
            digits[j] = temp;

            // Преобразуем подмассив в список для сортировки
            List<char> sublist = digits.Skip(i).ToList();

            // Сортируем список в порядке убывания
            sublist.Sort((a, b) => -1 * a.CompareTo(b));

            // Заменяем соответствующую часть оригинального массива отсортированным списком
            for (int k = i, l = 0; k < digits.Length; k++, l++)
            {
                digits[k] = sublist[l];
            }

            long result = long.Parse(new string(digits));

            // Проверяем, что результат не начинается с нуля
            if (result.ToString().Length < digits.Length)
                return -1;

            return result;

        }

        //public static long NextSmaller(long n)
        //{
        //    var chars = n.ToString();
        //    for (var i = chars.Length - 1; i > 0; i--)
        //    {
        //        if (chars[i] < chars[i - 1])
        //        {
        //            var right = chars.Skip(i).ToArray();
        //            var next = right.Where(a => a < chars[i - 1]).Max();
        //            right[Array.IndexOf(right, next)] = chars[i - 1];
        //            var answer = chars.Substring(0, i - 1) + next + string.Concat(right.OrderByDescending(a => a));
        //            return answer[0] == '0' ? -1 : long.Parse(answer);
        //        }
        //    }
        //    return -1;
        //}


    }
}
