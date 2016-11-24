using System;

namespace TriangleSurfaceByTwoSidesAndAnAngle
{
    class TriangleSurfaceByTwoSidesAndAnAngle
    {
        static double CalculateTriangleArea(double a, double b, double angleDegrees)
        {
            double angleRadians = Math.PI * angleDegrees / 180.0;

            return 0.5 * a * b * Math.Sin(angleRadians);
        }

        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double angleDegrees = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", CalculateTriangleArea(a, b, angleDegrees));
        }
    }
}
