using System;
using System.Text.RegularExpressions;

namespace ParseTags
{
    class ParseTags
    {
        static void Main()
        {
            string text = Console.ReadLine();
            Console.WriteLine(Regex.Replace(text, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper()));
        }
    }
}
