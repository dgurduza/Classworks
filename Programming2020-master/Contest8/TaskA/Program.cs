using System;

delegate double Calculate(int n);

class Program
{
    public static double GetResult(int x)
    {
        double res = 0;
        for(int i = 1; i <= 5; i++)
        {
            res += Math.Pow(x,5) * Math.Pow((i + 42),5) / 14400;
        }
        return res;
    }
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Calculate calculate = GetResult;
        Console.WriteLine($"{calculate(n):f3}");
    }
}