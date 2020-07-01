using System;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение, которые хотите получить:");
            string messege = Console.ReadLine();
            Console.WriteLine("Введите сколько раз нужно повторить ваше сообщение");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(messege);
            }
        }
    }
}