using System;

namespace SayHello
{
    class SayHello
    {
        static void Greet()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
        static void Main(string[] args)
        {
            Greet();
        }
    }
}
