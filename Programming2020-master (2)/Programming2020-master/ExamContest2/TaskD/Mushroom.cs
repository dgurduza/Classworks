using System;
using System.Collections.Generic;

public class Mushroom
{
    private string Name { get; }
    private double Weight { get; }
    private double Diameter { get; }

    private Mushroom(string name, double weight, double diameter)
    {
        Name = name;
        Weight = weight;
        Diameter = diameter;
    }

    public static Mushroom Parse(string line)
    {
        string[] mas = line.Split(new char[] { ' ' });
        double w;
        double d;
        if (mas.Length !=3)
        {
            throw new ArgumentException("Incorrect input");
        }
        if (!double.TryParse(mas[1], out w) || w <= 0) 
        {
            throw new ArgumentException("Incorrect input");
        }
        if (!double.TryParse(mas[2], out d) || d <= 0)
        {
            throw new ArgumentException("Incorrect input");
        }
        Mushroom mush = new Mushroom(mas[0], w,d);
        return mush;
    }

    public static double GetAverageDiameter(List<Mushroom> mushrooms, double m)
    {
        double res = 0;
        double num;
        int count = 0;
        for(int i = 0; i < mushrooms.Count; i++)
        {
            if (mushrooms[i].Weight > m)
            {
                res += mushrooms[i].Diameter;
                count++;
            }
        }
        if (res == 0)
        {
            num = 0;
        }
        else
        {
            num = res / count;
        }
        return num;
    }
}