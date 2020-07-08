using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
           bool workProg = true;

            Console.WriteLine("Введите количество чисел");
            int userValue = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[userValue];
            int sum = 0;
            string userInPut;
            Console.WriteLine();

            Console.WriteLine($"Введите {userValue} чисел ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            while (workProg)
            {

                Console.WriteLine("1. Чтобы сложить все числа массива введите команду \"sum\"" +
                    "\n2. Для того чтобы завершить программу введите команду \"exit\"");

                userInPut = Console.ReadLine();

                if (userInPut == "sum")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write(array[i] + " ");
                        sum += array[i];
                    }
                    Console.WriteLine($"\nСумма чисел в массиве равна {sum}");
                }
                else if (userInPut == "exit")
                {
                    workProg = false;
                }
                else
                {
                    Console.WriteLine("Неизвестная команда. Проверьте правильность ввода команды.");
                }

            }
        }
    }
}
