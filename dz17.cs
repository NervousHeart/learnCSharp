using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace dz17
{
    class dz17
    {
        static void Main(string[] args)
        {
            int[] array = new int[30];
            int localMax;
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\nЛокальные максимальные значения:\n");

                if (array[0]>array[1])
                {
                    Console.Write(array[0] + " ");
                }
            for (int i = 0; i < array.Length; i++)
            {
                if (i!=0 && array[i]!= array[array.Length-1] && array[i]>array[i-1] && array[i] > array[i+1])
                {
                    Console.Write(array[i] + " ");
                }

            }
                if (array[array.Length-1]>array[array.Length-2])
                {
                    Console.Write(array[array.Length-1] + " ");
                }

        }
    }
}
