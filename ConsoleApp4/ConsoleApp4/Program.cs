using System;
using System.Security.Cryptography;
using System.IO;

namespace ConsoleApp4
{
    internal static class Program
    {
        public class Point
        {
            private readonly double x;
            private readonly double y;

            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public double GetX() => x;
            public double GetY() => y;
        }
        public class Triangle
        {
            private readonly Point a;
            private readonly Point b;
            private readonly Point c;

            private double AB => GetLengthOfSide(a, b);
            private double AC => GetLengthOfSide(a, c);
            private double BC => GetLengthOfSide(b, c);

            public Triangle(Point a, Point b, Point c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public double GetPerimeter()
            {
                return AB + AC + BC;
            }

            public double GetSquare()
            {
                double semiPerimeter = (AB + AC + BC) / 2;
                return Math.Sqrt(semiPerimeter * (semiPerimeter - AB) * (semiPerimeter - BC) * (semiPerimeter - AC));
            }

            public bool GetAngleBetweenEqualsSides(out double angle)
            {
                if (BC == AC)
                {
                    angle = Math.Acos(1 - (Math.Pow((AB / BC), 2) / 2));
                    return true;
                }
                else
                if (AB == BC)
                {
                    angle = Math.Acos(1 - (Math.Pow((AC / AB), 2) / 2));
                    return true;
                }
                else
                if (AC == AB)
                {
                    angle = Math.Acos(1 - (Math.Pow((BC / AC), 2) / 2));
                    return true;
                }
                else
                {
                    angle = 0;
                    return false;
                }
            }

            public bool GetHypotenuse(out double hypotenuse)
            {
                if (Math.Abs(AC * AC + BC * BC - AB * AB) < 0.00001)
                {
                    hypotenuse = AB;
                    return true;
                }
                else
                if (Math.Abs(AC * AC + AB * AB - BC * BC) < 0.00001)
                {
                    hypotenuse = BC;
                    return true;
                }
                else
                if (Math.Abs(BC * BC + AB * AB - AC * AC) < 0.00001)
                {
                    hypotenuse = AC;
                    return true;
                }
                else
                {
                    hypotenuse = 0;
                    return false;
                }
            }


            private static double GetLengthOfSide(Point first, Point second)
            {
                double x = first.GetX();
                double y = first.GetY();
                double x1 = second.GetX();
                double y1 = second.GetY();
                return Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2));

            }
        }


        private static Point GetPointFromInput()
        {
            double[] coordinates = Array.ConvertAll(Console.ReadLine().Split(' '),
                x => double.Parse(x));

            return new Point(coordinates[0], coordinates[1]);
        }

        private static void Main(string[] args)
        {
            var a = GetPointFromInput();
            var b = GetPointFromInput();
            var c = GetPointFromInput();

            var triangle = new Triangle(a, b, c);

            Console.WriteLine($"{triangle.GetPerimeter():F3}{Environment.NewLine}{triangle.GetSquare():F3}");

            if (triangle.GetAngleBetweenEqualsSides(out double angle))
            {
                Console.WriteLine($"equilateral: {angle:F3}");
            }

            if (triangle.GetHypotenuse(out double hypotenuse))
            {
                Console.WriteLine($"rectangular: {hypotenuse:F3}");
            }
        }
    }
}
