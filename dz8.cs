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
                Console.WriteLine("Программа работает, если вы введете любое слово - программа все так же будет работать");
                Console.ReadLine();
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