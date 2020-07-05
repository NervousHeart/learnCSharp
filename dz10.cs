using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool work = true;

            while (work)
            {

                Console.WriteLine($"1. Изменить цвет текста" +
                    $"\n2. Изменить цвет консоли" +
                    $"\n3. Изменить высоту консоли" +
                    $"\n4. Изменить ширину консоли" +
                    $"\n5. Вывести текст в консоли" +
                    $"\n6. Выйти из программы");
                int choiseNumber = Convert.ToInt32(Console.ReadLine());
                switch (choiseNumber)
                {
                    case 1:
                        Console.WriteLine("Выберите один их цветов: red, blue, white");
                        string color = Console.ReadLine();
                        if (color == "red")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                        }
                        else if (color == "blue")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Clear();

                        }
                        else if (color == "white")
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();

                        }
                        break;
                    case 2:
                        Console.WriteLine("Выберите один их цветов: red, blue, black");
                        color = Console.ReadLine();
                        if (color == "red")
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Clear();
                        }
                        else if (color == "blue")
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Clear();
                        }
                        else if (color == "white")
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Введите высоту:");
                        int height = Convert.ToInt32(Console.ReadLine());
                        Console.WindowHeight = height;
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Введите ширину:");
                        int width = Convert.ToInt32(Console.ReadLine());
                        Console.WindowWidth = width;
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Введите текст, который хотите написать:\n");
                        string text = Console.ReadLine();
                        break;
                    case 6:
                        work = false;
                        break;
                    default:
                        Console.WriteLine("Неправильный ввод");
                        break;
                }
            }
        }
    }
}