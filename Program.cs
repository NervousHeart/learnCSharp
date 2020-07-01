using System;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {

            int pictures = 52;
            int picturesInRow = 3;
            int allPicturesInRow = pictures / picturesInRow;
            int picturesOutRow = pictures % picturesInRow;

            Console.WriteLine($"Всего картин - {pictures}. \nПолностью заполненных рядов картин получилось - {allPicturesInRow}. " +
                $"\nОстаток картин - {picturesOutRow}.");
            Console.ReadKey();
        }
    }
}
