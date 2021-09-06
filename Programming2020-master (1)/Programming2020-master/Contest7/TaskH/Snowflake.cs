using System;

public class Snowflake
{
    public int Width { get; set; }
    public int Rays { get; set; }

    public Snowflake(int widthAndHeight, int raysCount)
    {
        if (widthAndHeight % 2 != 0)
        {
            Width = widthAndHeight;
        }
        else
        {
            throw new ArgumentException("Incorrect input");
        }
        int count = 0;
        for (; ; )
        {
            if (raysCount % 2 == 0 || raysCount == 1)
            {
                if (raysCount == 1)
                {
                    break;
                }
                raysCount /= 2;
                count++;
            }
            else
            {
                throw new ArgumentException("Incorrect input");
            }
        }
        if (count < 2)
        {
            throw new ArgumentException("Incorrect input");
        }
        else
        {
            Rays = raysCount;
        }
    }

    public override string ToString()
    {
        string str = "";
        for (int i = 1; i <= Width; i++)
        {
            if (i % 2 != 0)
            {
                for (int j = 1; j <= Width; j++)
                {
                    if (j % 2 != 0)
                    {
                        str += "*";
                    }
                    else
                    {
                        str += " ";
                    }
                }
                if(i+1!=Width)
                    str += Environment.NewLine;
            }
            else
            {
                for (int j = 1; j <= Width; j++)
                {
                    if (j % 2 == 0)
                    {
                        str += "*";
                    }
                    else
                    {
                        str += " ";
                    }
                }
                str += Environment.NewLine;
            }
        }
        return str;
    }
}