using System;
using System.Globalization;

namespace LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string yearFormat;
            switch (input.Length)
            {
                case 2: yearFormat = "yy"; break;
                case 3: yearFormat = "yyy"; break;
                default: yearFormat = "yyyy"; break;
            }

            DateTime date = DateTime.ParseExact(input, yearFormat, CultureInfo.InvariantCulture);
            Console.WriteLine(DateTime.IsLeapYear(date.Year) ? "Leap" : "Common");
        }
    }
}
