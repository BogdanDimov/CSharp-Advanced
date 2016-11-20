using System;

namespace GetLargestNumber
{
    class GetLargestNumber
    {
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ');

            Console.WriteLine(GetMax(GetMax(int.Parse(nums[0]), int.Parse(nums[1])), int.Parse(nums[2])));
        }
    }
}
