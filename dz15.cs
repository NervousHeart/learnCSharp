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
            
            //заполнение массива
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(0, 10);
                }
            }
            
            //операции с ячейками массива
                for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                }
                    multiplicationOneColumn *= array[i, 0];
                    sumSecondRow += array[1, i];
            }
            
            //вывод массива
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
                Console.WriteLine("произведение первого столбца: " + multiplicationOneColumn);
                Console.WriteLine("сумма второй строки: " + sumSecondRow);

        }
    }
}
