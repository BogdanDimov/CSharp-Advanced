using System;
using System.Numerics;

namespace NFactorial
{
    class NFactorial
    {
        static BigInteger FindFactorial(BigInteger num)
        {
            if (num == 0) return 1;
            return num * FindFactorial(num - 1);
        }
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(FindFactorial(n));
        }
    }
}
