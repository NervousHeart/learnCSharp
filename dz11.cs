using System;
using System.ComponentModel;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=7;i <= 98; i+=7) // Здесь был выбран цикл for потому что известно конечное число последовательности и ее шаг. 
            {
                Console.Write(i + " ");
            }
        }
    }
}
