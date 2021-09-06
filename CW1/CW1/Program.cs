using System;

namespace CW1
{
    class Program
    {
        public delegate int[] Del1(int num);
        public delegate void Del2(int[] masNum);

        public static int[] GetMass(int a)
        {
            string str = a.ToString();
            int[] mas = new int[str.Length];
            for(int i = 0; i < str.Length; i++)
            {
                mas[i] = int.Parse(str[i].ToString());
                str.Substring(1);
            }
            return mas;
        }
        public static void Screen(int [] d)
        {
            for(int i = 0; i < d.Length; i++)
            {
                Console.WriteLine(d[i]);
            }
        }
        static void Main(string[] args)
        {
            Del1 intDel = GetMass;
            Del2 voidDell = Screen;
            intDel?.Invoke(12345);
            voidDell.Invoke(intDel?.Invoke(12345));
            Console.WriteLine(intDel.Target);
            Console.WriteLine(intDel.Method);
        }
    }
}
