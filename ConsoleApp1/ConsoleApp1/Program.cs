using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumLine = 0;
            int sumColumn = 0;
            int[,] array = { { 1, 2 }, { 3, 4 } };
            Console.WriteLine("Исходный массив");

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < array.GetLength(1); i++)
            {
                sumLine += array[1, i];
            }
            Console.WriteLine($"Cумма второй строки: {sumLine}");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                sumColumn += array[i, 0];
            }
            Console.WriteLine($"Cумма первого столбца: {sumColumn}");
        }
    }
}