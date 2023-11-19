using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace MostFrequentlyWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }

        public static List<string> Top3(string s)
        {
            return Regex.Matches(s.ToLowerInvariant(), @"('*[a-z]'*)+")
            .GroupBy(match => match.Value)
            .OrderByDescending(g => g.Count())
            .Select(p => p.Key)
            .Take(3)
            .ToList();
        }
    }
}