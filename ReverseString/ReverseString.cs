using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        static string ReverseTheString(string inputStr)
        {
            StringBuilder sb = new StringBuilder(inputStr.Length);

            for (int i = inputStr.Length - 1; i >= 0; i--)
            {
                sb.Append(inputStr[i]);
            }

            return sb.ToString();
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(ReverseTheString(input));
        }
    }
}
