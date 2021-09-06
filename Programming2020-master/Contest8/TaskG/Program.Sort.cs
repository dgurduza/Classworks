using System;

partial class Program
{
    public static int CompareDigits(int x, int y)
    {
        if (x / 10 == 0)
        {
            if (y / 10 == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        else if (y / 10 == 0)
        {
            if (x / 10 == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        else
        {
            string strx = x.ToString();
            string stry = y.ToString();
            if (strx.Length == stry.Length)
            {
                return 0;
            }
            else if (strx.Length > stry.Length)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
    internal static int[] StrangeSort(int[] arr)
    {
        int[] array = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            array[i] = arr[i];
        }
        Array.Sort(array, CompareDigits);
        return array;
    }
}