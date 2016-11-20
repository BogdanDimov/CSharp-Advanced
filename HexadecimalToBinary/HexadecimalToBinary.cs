using System;

namespace HexadecimalToBinary
{
    class HexadecimalToBinary
    {
        static string HexToBinConvert(string hex)
        {
            string binNumber = string.Empty;

            for (int i = 0; i < hex.Length; i++)
            {
                switch (hex[i])
                {
                    case '0': binNumber = binNumber + "0000"; break;
                    case '1': binNumber = binNumber + "0001"; break;
                    case '2': binNumber = binNumber + "0010"; break;
                    case '3': binNumber = binNumber + "0011"; break;
                    case '4': binNumber = binNumber + "0100"; break;
                    case '5': binNumber = binNumber + "0101"; break;
                    case '6': binNumber = binNumber + "0110"; break;
                    case '7': binNumber = binNumber + "0111"; break;
                    case '8': binNumber = binNumber + "1000"; break;
                    case '9': binNumber = binNumber + "1001"; break;
                    case 'A': binNumber = binNumber + "1010"; break;
                    case 'B': binNumber = binNumber + "1011"; break;
                    case 'C': binNumber = binNumber + "1100"; break;
                    case 'D': binNumber = binNumber + "1101"; break;
                    case 'E': binNumber = binNumber + "1110"; break;
                    case 'F': binNumber = binNumber + "1111"; break;
                }
            }

            // remove leading zeros
            while (true)
            {
                if (binNumber[0] == '0')
                {
                    binNumber = binNumber.Remove(0, 1);
                }
                else break;
            }

            return binNumber;
        }

        static void Main()
        {
            string hex = Console.ReadLine();

            Console.WriteLine(HexToBinConvert(hex));
        }
    }
}
