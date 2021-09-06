using System;

class Program
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string[] masstr = str.Split(new char[] { ' ' });
        double temp = 0;
        for(int i = 0; i < masstr.Length; i++)
        {
            temp += double.Parse(masstr[i]);
        }
        double res = temp / masstr.Length;
        Console.WriteLine($"{res:f3}");
    }
}