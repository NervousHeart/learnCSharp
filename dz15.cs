sing System;

namespace ConsoleApp6111
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5] ;
            Random rand = new Random();
            int sumSecondRow = 0; int multiplicationOneColumn = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(0, 10);
                    Console.Write(array[i, j]);
                    if (i==1)
                    {
                        sumSecondRow += array[i, j];
                    }
                    if (j==0)
                    {
                        multiplicationOneColumn *= array[i, j];
                    }

                }

                Console.WriteLine();

            }
                Console.WriteLine("произведение первого столбца: " + multiplicationOneColumn);
                Console.WriteLine("сумма второй строки: " + sumSecondRow);
        }
    }
}
