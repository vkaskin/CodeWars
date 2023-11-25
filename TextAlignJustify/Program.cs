using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.Linq;

namespace TextAlignJustify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Justify("123 45 6", 7));
            Console.ReadKey();
        }

        public static string Justify(string str, int len)
        {
            string[] words = str.Split(' ');
            List<string> lines = new List<string>();
            List<string> currentLine = new List<string>();
            int currentWidth = 0;

            foreach (string word in words)
            {
                if (currentWidth + word.Length + currentLine.Count > len)
                {
                    lines.Add(CreateLine(currentLine, currentWidth, len, false));
                    currentLine.Clear();
                    currentWidth = 0;
                }

                currentLine.Add(word);
                currentWidth += word.Length;
            }

            
            lines.Add(CreateLine(currentLine, currentWidth, len, true));

            return string.Join("\n", lines);
        }

        static string CreateLine(List<string> words, int currentWidth, int maxWidth, bool lastLine)
        {
            int totalSpaces = maxWidth - currentWidth;
            int spacesCount = words.Count - 1;

            if (spacesCount == 0 || lastLine)
            {
                return string.Join(" ", words);
            }

            int largerSpaces = totalSpaces % spacesCount;
            int smallerSpaces = spacesCount - largerSpaces;
            int largerSpaceWidth = totalSpaces / spacesCount + 1;
            int smallerSpaceWidth = totalSpaces / spacesCount;

            string line = "";
            for (int i = 0; i < words.Count - 1; i++)
            {
                line += words[i];
                line += new string(' ', i < largerSpaces ? largerSpaceWidth : smallerSpaceWidth);
            }
            line += words.Last();

            return line;
        }
    }
}
