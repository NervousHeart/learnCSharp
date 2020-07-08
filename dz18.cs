using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace dz17
{
    class dz18
    {
        static void Main(string[] args)
        {
            int[] array = new int[0];
            string userInPut;
            int sum = 0;
            bool workProg = true;

            while (workProg)
            {

                Console.Write("Массив: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }

                Console.WriteLine("\nДобавить число в массив - input\nСложить все числа массива - sum\nВыйти из программы - exit");
                userInPut = Console.ReadLine();
                if (userInPut == "input")
                {
                    int[] tempArray = new int[array.Length + 1];
                    for (int i = 0; i < array.Length; i++)
                    {
                        tempArray[i] = array[i];
                    }
                    tempArray[tempArray.Length-1] = Convert.ToInt32(Console.ReadLine());
                    array = tempArray;
                    Console.Clear();
                }

                else if (userInPut == "sum")
                {

                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write(array[i] + " ");
                        sum += array[i];
                    }
                    Console.Clear();
                    Console.WriteLine("Сумма всех чисел равна: " + sum);
                    
                }
                else if (userInPut == "exit")
                {
                    Console.Clear();

                    workProg = false;
                }

                else
                {
                    Console.Clear();

                    Console.WriteLine("Неизвестная команда, попробуйте еще раз");
                }
            }
        }
    }
}
