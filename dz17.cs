using System;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите количество чисел");
            int userValue = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[userValue];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}
