using System;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static void ReadNumber(int start, int end)
        {
            int[] numArray = new int[12];
            numArray[0] = start;
            numArray[numArray.Length - 1] = end;
            try
            {
                bool throwException = false;
                for (int i = 1; i < numArray.Length - 1; i++)
                {
                    numArray[i] = int.Parse(Console.ReadLine());
                    if (numArray[i] <= numArray[i - 1] || numArray[i] >= numArray[numArray.Length - 1])
                    {
                        throwException = true;
                    }
                }

                if (throwException)
                {
                    throw new Exception();
                }

                Console.WriteLine(string.Join(" < ", numArray));
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }

        static void Main()
        {
            int start = 1;
            int end = 100;
            ReadNumber(start, end);
        }
    }
}
