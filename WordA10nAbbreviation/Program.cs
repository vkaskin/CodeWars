using System.Text;
using System.Text.RegularExpressions;

namespace WordA10nAbbreviation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AbbreviateWords("my. dog, isn't feeling very well."));
            Console.ReadKey();
        }

        
        static string AbbreviateWords(string input)
        {
            // Используем регулярное выражение для поиска слов длиной 4 и более букв
            string pattern = @"\b\w{4,}\b";
            Regex regex = new Regex(pattern);

            // Для каждого найденного слова вызываем метод MatchEvaluator, который возвращает замену
            string result = regex.Replace(input, new MatchEvaluator(AbbreviateMatch));

            return result;
        }

        static string AbbreviateMatch(Match match)
        {
            string word = match.Value;

            // Проверяем, состоит ли слово только из букв
            if (Regex.IsMatch(word, @"^[a-zA-Z]+$"))
            {
                // Формируем аббревиатуру
                int length = word.Length - 2; // количество удаленных символов
                return $"{word[0]}{length}{word[^1]}";
            }
            else
            {
                // Слово содержит другие символы (например, пробел или дефис)
                return word;
            }
        }
    }
}
