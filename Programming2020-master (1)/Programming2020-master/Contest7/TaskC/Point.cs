using System;

public class Point
{
    int X;
    int Y;
    int Z;
    public Point(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public override bool Equals(object obj)
    {
        Point ar = (Point)obj;
        if (this.X != ar.X && this.Y != ar.Y && this.Z != ar.Z)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public override int GetHashCode() => Tuple.Create(X, Y, Z).GetHashCode();

    public override string ToString() => $"{X} {Y} {Z}";
}