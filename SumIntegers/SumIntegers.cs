using System;
using System.Numerics;

namespace SumIntegers
{
    class SumIntegers
    {
        static BigInteger CalculateSumOfInts(int[] ints)
        {
            BigInteger sum = 0;

            foreach (var i in ints)
            {
                sum += i;
            }

            return sum;
        }

        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] integers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                integers[i] = int.Parse(input[i]);
            }

            Console.WriteLine(CalculateSumOfInts(integers));
        }
    }
}
