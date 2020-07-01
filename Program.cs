using System;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* На экране в специальной зоне выводятся картинки, по 3 в ряд.
             * Всего у пользователя в альбоме 52 картинки.
             * Код должен вывести, сколько полностью заполненных рядов можно будет вывести, и сколько картинок будет сверх меры.
               В качестве решения ожидается объявленные переменные с необходимыми значениями
               и вывод необходимых данных основываясь на значениях переменных. */

            int pictures = 52;
            int picturesInRow = 3;
            int picturesOutRow = pictures % picturesInRow;

            Console.WriteLine($"Всего картин - {pictures}. \nПолностью заполненных рядов картин получилось - {pictures / picturesInRow}. " +
                $"\nОстаток картин - {pictures % picturesInRow}.");
            Console.ReadKey();
        }
    }
}
