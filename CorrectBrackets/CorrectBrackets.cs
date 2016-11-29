using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBrackets
{
    class CorrectBrackets
    {
        static string CheckExpression(string expression)
        {
            int openingBrackets = 0;
            int closingBrackets = 0;

            StringBuilder sb = new StringBuilder(expression);

            foreach (var c in sb.ToString())
            {
                if (c == '(')
                {
                    openingBrackets++;
                }

                if (c == ')')
                {
                    closingBrackets++;
                }
            }

            return (openingBrackets == closingBrackets) ? "Correct" : "Incorrect";
        }

        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Console.WriteLine(CheckExpression(expression));
        }
    }
}
