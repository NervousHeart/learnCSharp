using System;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* На экране в специальной зоне выводятся картинки, по 3 в ряд. Всего у пользователя в альбоме 52 картинки.
            Код должен вывести, сколько полностью заполненных рядов можно будет вывести, и сколько картинок будет сверх меры.
            В качестве решения ожидается объявленные переменные с необходимыми значениями
            и вывод необходимых данных основываясь на значениях переменных. */

            int pictures = 52;
            int picturesInRow = 3;

            int picturesWholeRow = pictures / picturesInRow;

            Console.WriteLine($"Количество полностью заполненных рядов картин - {picturesWholeRow}.");

            int picturesExceededTheLimit = pictures % picturesInRow;

            Console.WriteLine($"Количество картин не поместившиеся в ряд - {picturesExceededTheLimit}");





        }
    }
}
