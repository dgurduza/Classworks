using System;
using System.Collections.Generic;
using System.IO;

public partial class Program
{
    /// <summary>
    /// Считывает точки в список.
    /// </summary>
    /// <returns>Список точек.</returns>
    private static List<Point> GetPoints()
    {
        string []str = File.ReadAllLines(InputPath);
        List<Point> points = new List<Point>();
        for(int i = 0; i < str.Length; i++)
        {
            string[] temp = str[i].Split(new char[] { ' ' });
            points.Add(new Point(int.Parse(temp[0]), int.Parse(temp[1]), int.Parse(temp[2])));
        }
        return points;
    }


    /// <summary>
    /// Получает коллекцию уникальных точек.
    /// </summary>
    /// <param name="points">Список исходных точек.</param>
    /// <returns>Коллекция точек.</returns>
    private static HashSet<Point> GetUnique(List<Point> points)
    {
        HashSet<Point> unique = new HashSet<Point>();
        for (int i = 0; i < points.Count; i++)
        {
            if (!unique.Contains(points[i]))
            {
                unique.Add(points[i]);
            }
        }
        return unique;
    }
}