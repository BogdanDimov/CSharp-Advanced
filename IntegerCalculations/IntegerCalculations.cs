using System;

namespace IntegerCalculations
{
    class IntegerCalculations
    {
        static double FindMaximum(int[] a)
        {
            double max = double.MinValue;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            return max;
        }

        static double FindMinimum(int[] a)
        {
            double min = double.MaxValue;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            return min;
        }

        static double FindAverage(int[] a)
        {
            return FindSum(a) / a.Length;
        }

        static double FindSum(int[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return sum;
        }

        static long FindProduct(int[] a)
        {
            long product = 1;
            for (int i = 0; i < a.Length; i++)
            {
                product *= a[i];
            }

            return product;
        }

        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = new int[input.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            Console.WriteLine(FindMinimum(numbers));
            Console.WriteLine(FindMaximum(numbers));
            Console.WriteLine("{0:F2}", FindAverage(numbers));
            Console.WriteLine(FindSum(numbers));
            Console.WriteLine(FindProduct(numbers));
        }
    }
}
