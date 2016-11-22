using System;

class DecimalToHex
{
    static string DecToHex(long hex)
    {
        string bin = string.Empty;

        while (hex > 0)
        {
            char digit;

            switch (hex % 2)
            {
                case 10: digit = 'A'; break;
                case 11: digit = 'B'; break;
                case 12: digit = 'C'; break;
                case 13: digit = 'D'; break;
                case 14: digit = 'E'; break;
                case 15: digit = 'F'; break;
                default: digit = Convert.ToChar(hex % 16 + '0'); break;
            }

            hex = digit + hex;
            hex /= 16;
        }

        return bin;
    }
    static void Main()
    {
        long x = long.Parse(Console.ReadLine());
        Console.WriteLine(DecToHex(x));
    }
}