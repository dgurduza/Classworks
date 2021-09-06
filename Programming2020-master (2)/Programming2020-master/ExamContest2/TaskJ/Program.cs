using System;

class Program
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string[] mas = str.Split(new char[] { ' ' });
        string str2 = Console.ReadLine();
        string[] mas2 = str2.Split(new char[] { ' ' });
        int count = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            if (i < mas2.Length)
            {
                if (mas[i] == mas2[i])
                {
                    count++;
                }
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(count);
    }
}