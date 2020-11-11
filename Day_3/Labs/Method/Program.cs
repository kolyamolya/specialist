using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = SquareEq(1, 2, 3);

            if (!result.hasRoots)
            {
                Console.WriteLine(result);
            }

        }

        public static (double x1, double x2, bool hasRoots, bool hasSingleRoot) 
            SquareEq(double a, double b, double c) 
        {

            if (a == 0d) 
            {
                throw new ArgumentException("a == 0");
            }

            double d = b * b - 4 * a * c;

            if (d < 0d)
            {
                return (0d, 0d, false, false);
            }
            else if (d == 0d)
            {
                double x = -b / (2 * a);
                return (x, x, true, true);
            }
            else 
            {
                double ds = Math.Sqrt(d);
                double x1 = (-b + ds) / (2 * a);
                double x2 = (-b - ds) / (2 * a);
                return (x1, x2, true, false);
            }

        }

    }
}
