using System;

namespace TriangleSurfaceByThreeSides
{
    class TriangleSurfaceByThreeSides
    {
        static double CalculateArea(double a, double b, double c)
        {
            double p = CalculatePerimeter(a, b, c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static double CalculatePerimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", CalculateArea(a, b, c));
        }
    }
}
