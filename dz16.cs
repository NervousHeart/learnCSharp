using System;

namespace ConsoleApp6111
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            Random rand = new Random();
            int maxNumber = int.MinValue;

            Console.WriteLine("Исходный массив");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(0, 100);
                    Console.Write(array[i, j] + "  ");
                    if (maxNumber < array[i, j])
                    {
                        maxNumber = array[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nНаибольший элемент" + maxNumber);

            Console.WriteLine("\n\nИзмененный массив\n\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] == maxNumber)
                    {
                        array[i, j] = 0;
                    }
                    Console.Write(array[i, j] + "  ");
                }
                Console.WriteLine();
            }

        }
    }
}
