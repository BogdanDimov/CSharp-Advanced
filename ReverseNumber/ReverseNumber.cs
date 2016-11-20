using System;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static string Reverse(string number)
        {
            char[] array = number.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(Reverse(number));
        }
    }
}
