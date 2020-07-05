using System;
using System.ComponentModel;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 7;
            while (number <= 98) // Здесь был выбран цикл while потому что известно конечное число последовательности и ее шаг. 
            {
                Console.Write(number + " ");
                number += 7;
            }
        }
    }
}