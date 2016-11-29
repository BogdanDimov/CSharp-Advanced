using System;
using System.Text;

namespace SubstringInText
{
    class SubstringInText
    {
        static int CheckOccurences(string pattern, string text)
        {
            int occurences = 0;
            int startIndex = 0;
            StringBuilder sb = new StringBuilder(text);

            while ((startIndex = sb.ToString().IndexOf(pattern, StringComparison.OrdinalIgnoreCase)) >= 0)
            {
                occurences++;
                sb.Remove(startIndex, pattern.Length);
            }

            return occurences;
        }

        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string input = Console.ReadLine();
            Console.WriteLine(CheckOccurences(pattern, input));
        }
    }
}
