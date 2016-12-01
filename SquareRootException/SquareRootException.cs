using System;

namespace SquareRootException
{
    class SquareRootException
    {
        static void Main()
        {
            try
            {
                double number;
                if (!double.TryParse(Console.ReadLine(), out number) || number < 0)
                {
                    throw new Exception("Invalid number");
                }
                else
                {
                    Console.WriteLine("{0:f3}", Math.Sqrt(number));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
