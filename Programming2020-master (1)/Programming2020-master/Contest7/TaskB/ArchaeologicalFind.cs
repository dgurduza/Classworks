using System;
using System.Collections.Generic;
#pragma warning disable

public class ArchaeologicalFind
{
    public static int TotalFindsNumber = 0;
    public static int Number = 0;
    public int IndexInList { get; set; }
    private int Weight;
    private string Name;
    private int Ages;
    public ArchaeologicalFind(int age, int weight, string name)
    {
        if (age > 0)
        {
            Ages = age;
        }
        else
        {
            throw new ArgumentException("Incorrect age");
        }
        if (weight > 0)
        {
            Weight = weight;
        }
        else
        {
            throw new ArgumentException("Incorrect weight");
        }
        if (name != "?")
        {
            Name = name;
        }
        else
        {
            throw new ArgumentException("Undefined name");
        }
        IndexInList = Number;
        Number++;
    }

    /// <summary>
    /// Добавляет находку в список.
    /// </summary>
    /// <param name="finds">Список находок.</param>
    /// <param name="archaeologicalFind">Находка.</param>
    public static void AddFind(ICollection<ArchaeologicalFind> finds, ArchaeologicalFind archaeologicalFind)
    {
        if (!finds.Contains(archaeologicalFind))
        {
            finds.Add(archaeologicalFind);
        }
        TotalFindsNumber++;
    }


    public override bool Equals(object obj)
    {
        ArchaeologicalFind ar = (ArchaeologicalFind)obj;
        if (this.Name != ar.Name )
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public override string ToString() => $"{IndexInList} {Name} {Ages} {Weight}";
}