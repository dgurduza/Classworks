using System;
using System.ComponentModel;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        internal class Matrix
        {
            int[,] matrix;

            public Matrix(string filename)
            {
                string[] mas = File.ReadAllLines(filename); 
                matrix = new int[mas.Length, mas[0].Split(';').Length];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    string[] stringsOfMas = mas[i].Split(';');
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        int.TryParse(stringsOfMas[j], out matrix[i, j]);
                    }
                }
                matrix.ToString();
            }
            public int SumOffEvenElements
            {
                get
                {
                    int sunOFDigits = 0;
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            if (matrix[i, j] % 2 == 0)
                            {
                                sunOFDigits += matrix[i, j];
                            }
                        }
                    }
                    return sunOFDigits;
                }
            }
            public override string ToString()
            {
                string stringsInMatrix = "";
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j == matrix.GetLength(1) - 1)
                        {
                            stringsInMatrix += matrix[i, j].ToString() + Environment.NewLine;
                        }
                        else
                        {
                            stringsInMatrix += matrix[i, j].ToString() + "\t";
                        }
                    }
                }
                return stringsInMatrix;
            }
        }
        public static void Main(string[] args)
        {
            Matrix matrix = new Matrix("D:\\matrix.txt");
            Console.Write(matrix);
            Console.WriteLine(matrix.SumOffEvenElements);
        }
    }
}
