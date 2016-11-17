using System;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[,] matrix = new int[n, m];

            // read the matrix
            for (int row = 0; row < n; row++)
            {
                string[] nums = Console.ReadLine().Split(' ');

                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = Convert.ToInt32(nums[col]);
                }
            }

            int sum = 0;
            int maxSum = int.MinValue;
            // find max sum of 3x3 square inside matrix
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = 0; j < m - 2; j++)
                {
                    for (int p = i; p < 3 + i; p++)
                    {
                        for (int q = j; q < 3 + j; q++)
                        {
                            sum += matrix[p, q];
                        }
                    }

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }

                    sum = 0;
                }
            }

            // print maxSum
            Console.WriteLine(maxSum);
        }
    }
}