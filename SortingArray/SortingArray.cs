using System;

namespace SortingArray
{
    class SortingArray
    {
        static string SortArray(int[] arr, int size)
        {
            int temp;

            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            return string.Join(" ", arr);
        }
        static int GetMaxElement(int[] arr, int startingIndex)
        {
            int max = int.MinValue;
            for (int i = startingIndex; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] stringArray = Console.ReadLine().Split(' ');
            int[] intArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                intArray[i] = int.Parse(stringArray[i]);
            }

            Console.WriteLine(SortArray(intArray, n));
        }
    }
}
