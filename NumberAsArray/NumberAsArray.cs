using System;

namespace NumberAsArray
{
    class NumberAsArray
    {
        static string AddNumbers(int[] a, int[] b)
        {
            int sum = 0;
            int carry = 0;
            string result = string.Empty;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] + b[i] + carry > 9)
                {
                    sum = a[i] + b[i] + carry - 10;
                    carry = 1;
                }
                else
                {
                    sum = a[i] + b[i] + carry;
                    carry = 0;
                }

                result += sum;
                sum = 0;
            }

            if (carry == 1)
            {
                result += carry;
            }

            return string.Join(" ", result.ToCharArray());
        }
        static void Main()
        {
            string[] sizes = Console.ReadLine().Split(' ');
            string[] firstNum = Console.ReadLine().Split(' ');
            string[] secondNum = Console.ReadLine().Split(' ');
            int[] num1 = new int[Math.Max(firstNum.Length, secondNum.Length)];
            int[] num2 = new int[Math.Max(firstNum.Length, secondNum.Length)];

            for (int i = 0; i < firstNum.Length; i++)
            {
                num1[i] = int.Parse(firstNum[i]);
            }

            for (int i = 0; i < secondNum.Length; i++)
            {
                num2[i] = int.Parse(secondNum[i]);
            }

            Console.WriteLine(AddNumbers(num1, num2));
        }
    }
}