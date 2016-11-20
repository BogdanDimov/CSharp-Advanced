using System;

namespace AppearanceCount
{
    class AppearanceCount
    {
        static int CountAppearances(int num, string[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (num == int.Parse(nums[i]))
                {
                    count++;
                }
            }

            return count;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] nums = new string[n];
            nums = Console.ReadLine().Split(' ');
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(CountAppearances(num, nums));
        }
    }
}
