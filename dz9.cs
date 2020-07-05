using System;
using System.ComponentModel;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint balanceRub; uint balanceUsd; uint balanceEur;
            uint rubToUsd = 70; uint rubToEur = 80;
            uint usdToRub = 68; uint eurToRub = 78;
            uint desireVolue;
            bool workExchange = true;
            bool insideWorkChoise = true;

            Console.WriteLine("Введите сколько у вас рублей:");
            balanceRub = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Введите сколько у вас долларов:");
            balanceUsd = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Введите сколько у вас евро:");
            balanceEur = Convert.ToUInt32(Console.ReadLine());

            while (workExchange)
            {
                Console.WriteLine($"Ваш баланс рублей: {balanceRub}" +
                    $"\nВаш баланс долларов: {balanceUsd}" +
                    $"\nВаш баланс евро: {balanceEur}"); 

                Console.WriteLine("\n1. Обменять рубли." +
                    "\n2. Обменять доллары." +
                    "\n3. Обменять евро." +
                    "\n4. Выйти.");

                int desireChoise = Convert.ToInt32(Console.ReadLine());
                do
                {
                    if (desireChoise == 1)
                    {
                        Console.WriteLine($"Ваш баланс рублей: {balanceRub}" +
                            $"\nВаш баланс долларов: {balanceUsd}" +
                            $"\nВаш баланс евро: {balanceEur}");

                        Console.WriteLine("\n1. Обменять рубли на доллары." +
                            "\n2. Обменять рубли на евро." +
                            "\n3. Выйти.");

                        desireChoise = Convert.ToInt32(Console.ReadLine());

                        switch (desireChoise)
                        {
                            case 1:
                                Console.WriteLine("Сколько рублей вы хотите обменять?");
                                desireVolue = Convert.ToUInt32(Console.ReadLine());
                                if (desireVolue<=balanceRub)
                                {
                                    balanceRub -= desireVolue - (desireVolue%rubToUsd);
                                    balanceUsd += desireVolue / rubToUsd;
                                }
                                else
                                {
                                    Console.WriteLine("У вас недостаточно денег для такой операции.");
                                }
                                break;
                            case 2:
                                Console.WriteLine("Сколько рублей вы хотите обменять?");
                                desireVolue = Convert.ToUInt32(Console.ReadLine());
                                if (desireVolue <= balanceRub)
                                {
                                    balanceRub -= desireVolue - (desireVolue % rubToEur);
                                    balanceEur += desireVolue / rubToEur;
                                }
                                else
                                {
                                    Console.WriteLine("У вас недостаточно денег для такой операции.");
                                }
                                break;
                            case 3:
                                insideWorkChoise = false;
                                break;
                        }
                    }
                    else if (desireChoise == 2)
                    {
                        Console.WriteLine($"Ваш баланс рублей: {balanceRub}" +
                            $"\nВаш баланс долларов: {balanceUsd}" +
                            $"\nВаш баланс евро: {balanceEur}");

                        Console.WriteLine("1. Обменять доллары на рубли." +
                            "\n2. Обменять доллары на евро." +
                            "\n3. Выйти.");

                        desireChoise = Convert.ToInt32(Console.ReadLine());

                        switch (desireChoise)
                        {
                            case 1:
                                Console.WriteLine("Сколько долларов вы хотите обменять?");
                                desireVolue = Convert.ToUInt32(Console.ReadLine());
                                if (desireVolue <= balanceUsd)
                                {
                                    balanceUsd -= desireVolue;
                                    balanceRub += desireVolue * usdToRub;
                                }
                                else
                                {
                                    Console.WriteLine("У вас недостаточно денег для такой операции.");
                                }
                                break;
                            case 2:
                                Console.WriteLine("Сколько долларов вы хотите обменять?");
                                desireVolue = Convert.ToUInt32(Console.ReadLine());
                                if (desireVolue <= balanceUsd)
                                {
                                    balanceUsd -= desireVolue;
                                    balanceEur += (desireVolue * usdToRub) / rubToEur;
                                    balanceRub += (desireVolue * usdToRub) % rubToEur;
                                }
                                else
                                {
                                    Console.WriteLine("У вас недостаточно денег для такой операции.");
                                }
                                break;
                            case 3:
                                insideWorkChoise = false;
                                break;
                        }

                    }
                    else if (desireChoise == 3)
                    {
                        Console.WriteLine($"Ваш баланс рублей: {balanceRub}" +
                            $"\nВаш баланс долларов: {balanceUsd}" +
                            $"\nВаш баланс евро: {balanceEur}");

                        Console.WriteLine("1. Обменять евро на рубли." +
                            "\n2. Обменять евро на доллары." +
                            "\n3. Выйти.");

                        desireChoise = Convert.ToInt32(Console.ReadLine());

                        switch (desireChoise)
                        {
                            case 1:
                                Console.WriteLine("Сколько евро вы хотите обменять?");
                                desireVolue = Convert.ToUInt32(Console.ReadLine());
                                if (desireVolue <= balanceEur)
                                {
                                    balanceEur -= desireVolue;
                                    balanceRub += desireVolue * eurToRub;
                                }
                                else
                                {
                                    Console.WriteLine("У вас недостаточно денег для такой операции.");
                                }
                                break;
                            case 2:
                                Console.WriteLine("Сколько евро вы хотите обменять?");
                                desireVolue = Convert.ToUInt32(Console.ReadLine());
                                if (desireVolue <= balanceEur)
                                {
                                    balanceEur -= desireVolue;
                                    balanceUsd += (desireVolue * eurToRub) / rubToUsd;
                                    balanceRub += (desireVolue * eurToRub) % rubToUsd;
                                }
                                else
                                {
                                    Console.WriteLine("У вас недостаточно денег для такой операции.");
                                }
                                break;
                            case 3:
                                insideWorkChoise = false;
                                break;
                        }

                    }
                    else if (desireChoise == 4)
                    {
                        workExchange = false;
                    }
                } while (insideWorkChoise);

            }
        }
    }
}