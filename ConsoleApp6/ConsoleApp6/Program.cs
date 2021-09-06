using System;

namespace ConsoleApp6
{
    class Program
    {
        public static string[] WithoutProbel(string cons)
        {
            string[] newCons = cons.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
            return newCons;
        }
        public static int Words(string cons)
        {
            int count = 0;
            string[] newCons = cons.Split(new char[] { ' ' });
            for(int i = 0; i < newCons.Length; i++)
            {
                if (newCons[i].Length > 4)
                {
                    count++;
                }
            }
            return count;
        }
        public static int Vowels(string cons)
        {
            int count = 0;
            string[] newCons = cons.Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
            for(int i =0; i< newCons.Length; i++)
            {
                if(newCons[i][0]== 'А'|| newCons[i][0] == 'Е' || newCons[i][0] == 'Ё' || newCons[i][0] == 'И' || newCons[i][0] == 'О' || newCons[i][0] == 'У'
                    || newCons[i][0] == 'Ы' || newCons[i][0] == 'Э' || newCons[i][0] == 'Ю' || newCons[i][0] == 'Я')
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            string cons = Console.ReadLine();
            for (int i = 0; i < WithoutProbel(cons).Length; i++)
            {
                Console.Write(WithoutProbel(cons)[i]+" ");
            }
            Console.WriteLine(Environment.NewLine+Words(cons));
            Console.WriteLine(Vowels(cons));
        }
    }
}
