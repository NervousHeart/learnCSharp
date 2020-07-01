using System;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool workProg = true;
                 while (workProg)
             {
                Console.WriteLine("Здравствуйте! Программа складывает любые целые числа!" +
                    "\nВведите первое целое число:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                int b = Convert.ToInt32(Console.ReadLine());
                int sum = a + b;
                Console.WriteLine("Сумма двух чисел равна: " + sum);
                Console.WriteLine("Чтобы выйти из программы введите - \"exit\"");
                string exit = Console.ReadLine();
                if (exit=="exit")
                {
                    workProg = false;
                }
             }
        }
    }
}
