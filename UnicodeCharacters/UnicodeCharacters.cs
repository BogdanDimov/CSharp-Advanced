using System;
using System.Text;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            byte[] stringBytes = Encoding.Unicode.GetBytes(inputString);
            char[] stringChars = Encoding.Unicode.GetChars(stringBytes);
            StringBuilder builder = new StringBuilder();
            Array.ForEach(stringChars, c => builder.AppendFormat("\\u{0:X4}", (int)c));
            Console.WriteLine(builder);
        }
    }
}