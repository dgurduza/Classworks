using System;

namespace ConsoleApp6
{
    class Triangle
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }

        public Triangle() { }

        public double P
        {
            get
            {
                return Distance(A, B) + Distance(B, C) + Distance(A, C);
            }
        }

        public double S
        {
            get
            {
                double p = P / 2;
                return Math.Sqrt(p * (p - Distance(A, B)) * (p - Distance(B, C)) * (p - Distance(A, C)));
            }
        }

        public double Distance(Point p1, Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            A = new Point(x1, y1);
            B = new Point(x2, y2);
            C = new Point(x3, y3);
        }

        public override string ToString()
        {
            return $"Triangle {S} \n 1 {A} \n 1 {B} \n 1 {C}";
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"Point {X} {Y}";
        }
    }
    public class Program
    {
        private static void Main()
        {
            Random random = new Random();

            int n = 10;

            Triangle[] triangles = new Triangle[n];

            for (int i = 0; i < n; i++)
            {
                triangles[i] = new Triangle(random.Next(-10, 10), random.Next(-10, 10),
                    random.Next(-10, 10), random.Next(-10, 10), random.Next(-10, 10),
                    random.Next(-10, 10));
                Console.WriteLine(triangles[i]);
            }

            Console.WriteLine("****");

            Array.Sort(triangles, (t1, t2) => t1.S.CompareTo(t2.S));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(triangles[i]);
            }

            Console.WriteLine("****");
        }
    }
}
