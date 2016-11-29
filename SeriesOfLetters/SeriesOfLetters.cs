using System;
using System.Text;

namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    sb.Append(input[i]);
                }
            }

            Console.WriteLine(sb);
        }
    }
}
