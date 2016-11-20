using System;

namespace AddingPolynomials
{
    class AddingPolynomials
    {
        static string AddPolynomials(int[] p1, int[] p2)
        {
            int[] result = new int[p1.Length];

            for (int i = 0; i < p1.Length; i++)
            {
                result[i] += p1[i] + p2[i];
            }

            return new string(string.Join(" ", result).ToCharArray());
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] pol1 = Console.ReadLine().Split(' ');
            string[] pol2 = Console.ReadLine().Split(' ');

            int[] p1 = new int[pol1.Length];
            int[] p2 = new int[pol2.Length];

            for (int i = 0; i < pol1.Length; i++)
            {
                p1[i] = int.Parse(pol1[i]);
            }

            for (int i = 0; i < pol2.Length; i++)
            {
                p2[i] = int.Parse(pol2[i]);
            }

            Console.WriteLine(AddPolynomials(p1, p2));
        }
    }
}
