using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            int length = sb.Length;

            if (length < 20)
            {
                for (int i = 0; i < 20 - length; i++)
                {
                    sb.Append('*');
                }
            }

            Console.WriteLine(sb);
        }
    }
}
