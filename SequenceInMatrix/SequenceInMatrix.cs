using System;

namespace SequenceInMatrix
{
    class SequenceInMatrix
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

            int seq = 1;
            int longest = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    for (int j = col + 1; j < m; j++) // check to the right
                    {
                        if (matrix[row, col] == matrix[row, j])
                        {
                            seq++;
                        }
                    }

                    if (seq > longest)
                    {
                        longest = seq;
                    }

                    seq = 1;

                    for (int i = row + 1; i < n; i++) // check downwards
                    {
                        if (matrix[row, col] == matrix[i, col])
                        {
                            seq++;
                        }
                    }

                    if (seq > longest)
                    {
                        longest = seq;
                    }

                    seq = 1;

                    for (int i = row + 1, j = col + 1; i < n && j < m; i++, j++) // check right diagonal
                    {
                        if (matrix[row, col] == matrix[i, j])
                        {
                            seq++;
                        }
                    }

                    if (seq > longest)
                    {
                        longest = seq;
                    }

                    seq = 1;

                    for (int i = row + 1, j = col - 1; i < n && j >= 0; i++, j--) // check left diagonal
                    {
                        if (matrix[row, col] == matrix[i, j])
                        {
                            seq++;
                        }
                    }

                    if (seq > longest)
                    {
                        longest = seq;
                    }

                    seq = 1;
                }
            }

            Console.WriteLine(longest);
        }
    }
}