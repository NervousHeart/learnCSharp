using System;
using System.ComponentModel;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            char symbol;
            string row;

            Console.WriteLine("Введите имя:");
            name = Console.ReadLine();
            Console.WriteLine("Введите символ");
            symbol = Convert.ToChar(Console.ReadLine());
            row = Convert.ToString(symbol);
            for (int i = 0; i <= name.Length; i++)
            {
                row += symbol;
            }
            Console.WriteLine(row + 
                $"\n{symbol}{name}{symbol}" +
                $"\n{row}");

        }
    }
}