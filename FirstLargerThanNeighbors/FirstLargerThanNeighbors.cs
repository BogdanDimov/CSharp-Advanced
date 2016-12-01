using System;

namespace FirstLargerThanNeighbors
{
    class FirstLargerThanNeighbors
    {
        static int GetIndexOfFirstLarger(int[] nums)
        {
            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1] && nums[i] > nums[i - 1])
                {
                    return i;
                }
            }

            return -1;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            string[] numsString = new string[n];
            numsString = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(numsString[i]);
            }

            Console.WriteLine(GetIndexOfFirstLarger(nums));

            string.Join("", numsString);
        }
    }
}
