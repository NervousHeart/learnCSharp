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
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
            
                for (int i = 0; i < array.GetLength(0);i++)
            {
                    multiplicationOneColumn *= array[i, 0];
            }
            
                for (int i = 1; i < 2; i++)
                {
                    for (int j = 0; j< array.GetLength(1);j++)
                    {
                        sumSecondRow+= array[i,j];
                    }
                }
            
                Console.WriteLine("произведение первого столбца: " + multiplicationOneColumn);
                Console.WriteLine("сумма второй строки: " + sumSecondRow);

        }
    }
}
