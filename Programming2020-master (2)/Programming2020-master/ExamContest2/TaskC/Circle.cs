using System;

public static class Circle
{
    public static double _circumference;
    public static double square;
    public static double Circumference(double radius)
    {
        _circumference = 2.0 * Math.PI * radius;
        return _circumference;
    }

    public static double Square(double radius)
    {
        square = Math.PI * Math.Pow(radius,2);
        return square;
    }

    public static double Distance(double x1, double y1, double r1, double x2, double y2, double r2)
    {
        double d = Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2));
        double L = d - r1 - r2;
        return L;
    }
}