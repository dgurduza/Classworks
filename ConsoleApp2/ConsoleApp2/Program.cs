using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string[] str = new string[3];
        str[0] = "Еда";
        str[1] = "Спорт";
        str[2] = "Хобби";
        Console.WriteLine("Введи название");
        string s = Console.ReadLine();
        if (s == "Еда")
        {
            Console.WriteLine(str[0]);
        }
        else if(s== "Спорт")
        {
            Console.WriteLine(str[1]);
        }
        else if(s == "Хобби")
        {
            Console.WriteLine(str[2]);
        }
        else
        {
            Console.WriteLine("Вы ввели неверное значение \n Дурак" +
                "");
        }
    }
}

