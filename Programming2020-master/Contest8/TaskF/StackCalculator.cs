using System;

public delegate void Calc(ref double x);

class StackCalculator
{
    public static void CreateRules(int[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] == 0)
            {
                Program.func += (ref double x) => x = Math.Sin(x);
            }
            else if (args[i] == 1)
            {
                Program.func += (ref double x) => x = Math.Cos(x);
            }
            else
            {
                Program.func += (ref double x) => x = Math.Tan(x);
            }
        }
    }
}