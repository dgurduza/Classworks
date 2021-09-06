using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        int temp;
        List<int> mas = new List<int>();
        do
        {
            string res = Console.ReadLine();
            temp = int.Parse(res);
            if (temp >= 100 && temp <= 150)
            {
                mas.Add(temp);
            }
            else if (temp != 0)
            {
                Console.WriteLine("Incorrect number");
            }
        } while (temp != 0);
        mas.Sort();
        Console.WriteLine(mas[mas.Count - 1].ToString());
        Console.WriteLine(mas[mas.Count - 2].ToString());
    }
}