using System;
using System.ComponentModel;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "perv1";
            string enterPassword;


                for (int i = 0; i < 4;)
                {
                    Console.WriteLine("\nВведите пароль:");
                    enterPassword = Console.ReadLine();
                    switch (enterPassword)
                    {
                        case "perv1":
                            Console.WriteLine("Очень тайное сообщение");
                        i = 0;
                            break;
                        default:
                            Console.WriteLine($"Неверный пароль, у вас осталось {3 - i} попытки");
                        i++;
                            break;
                    }
                }

        }
    }
}