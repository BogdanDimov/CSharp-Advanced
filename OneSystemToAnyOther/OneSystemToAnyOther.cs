using System;

namespace OneSystemToAnyOther
{
    class OneSystemToAnyOther
    {
        /// <summary>
        /// Convert a positive number 'num' to its digit representation in base 'd'.
        /// </summary>
        static string ToDigits(long num, int d)
        {
            string digits = string.Empty;

            while (num > 0)
            {
                string digitToAdd = Convert.ToString(num % d);
                switch (digitToAdd)
                {
                    case "10": digitToAdd = "A"; break;
                    case "11": digitToAdd = "B"; break;
                    case "12": digitToAdd = "C"; break;
                    case "13": digitToAdd = "D"; break;
                    case "14": digitToAdd = "E"; break;
                    case "15": digitToAdd = "F"; break;
                }

                digits = digitToAdd + digits;
                num /= d;
            }

            return digits;
        }

        /// <summary>
        /// Compute the number given by digits in base 's'.
        /// </summary>
        static long FromDigits(string digits, int s)
        {
            long n = 0;
            foreach (var digit in digits)
            {
                if (digit >= 'A' && digit <= 'F')
                {
                    n = s * n + digit - 55;
                }
                else
                {
                    n = s * n + digit - '0';
                }
            }

            return n;
        }

        /// <summary>
        /// Convert the digits representation of a number from base 's' to base 'd'.
        /// </summary>
        static string ConvertBase(string digits, int s, int d)
        {
            return ToDigits(FromDigits(digits, s), d);
        }

        static void Main()
        {
            int s = int.Parse(Console.ReadLine());
            string digits = Console.ReadLine();
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine(ConvertBase(digits, s, d));
        }
    }
}
