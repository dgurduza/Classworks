using System;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Warehouse house = new Warehouse();
            int sizeOfWarehouse;
            do
            {
                Console.WriteLine("Введи размер контейнера");
            } while (!int.TryParse(Console.ReadLine(), out sizeOfWarehouse));
            Warehouse newWarehouse = new Warehouse();
            do
            {
                try
                {

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                Console.WriteLine("Для продолжения нажмите любую клавишу на клавиатуре. Для выхода из программы веди \"Escape\"");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
