using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\..\MyTest.txt";
            string mas;
            using (FileStream fs = File.OpenRead(path))
            {
                byte[] arrBytes = new byte[fs.Length];
                fs.Read(arrBytes, 0, arrBytes.Length);
                mas = System.Text.Encoding.UTF8.GetString(arrBytes);
            }
            string[] str = mas.Split(new char[] {' '});
            int[] mass = new int[str.Length];
            for(int i = 0; i < str.Length; i++)
            {
                int num;
                if (int.TryParse(str[i], out num))
                {
                    mass[i] = num;
                }
            }
        }
    }
}
