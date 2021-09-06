using System;

public class IntWrapper
{
    private int number;

    public int Number
    {
        get { return number; }
    }

    public IntWrapper(int number)
    {
        this.number = number;
    }

    public uint FindNumberLength()
    {
        uint res = 0;
        if (number < 0)
            throw new ArgumentException("Number should be non-negative.");
        else
        {
            for (; ; )
            {
                if (number / 10 > 0)
                {
                    number /= 10;
                    res++;
                }
                else
                {
                    break;
                }
            }
        }
        return res + 1;
    }
}
