using System;

namespace TriangleSurfaceBySideAndAltitude
{
    class TriangleSurfaceBySideAndAltitude
    {
        static double CalculateArea(double side, double altitude)
        {
            return (side * altitude) / 2;
        }
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", CalculateArea(side, altitude));
        }
    }
}
