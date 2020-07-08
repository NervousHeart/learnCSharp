using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел");
            int userValue = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[userValue];
            int sum = 0;
            Console.WriteLine();

            Console.WriteLine($"Введите {userValue} чисел ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
                sum += array[i];
            }
            Console.WriteLine($"\nСумма чисел в массиве равна {sum}");
        }
    }
}
