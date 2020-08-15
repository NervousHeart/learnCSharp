using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawBar(40, 5, 5, ConsoleColor.Red);
            Console.ReadKey();
        }
        static void DrawBar(int value, int positionX, int positionY, ConsoleColor color)
        {
            int maxBar = 10;
            int nowBar = value / 10;


            ConsoleColor defoultColor = Console.BackgroundColor;
            string bar = "";

            for (int i = 0; i < nowBar; i++)
            {
                bar += "#";
            }
            Console.SetCursorPosition(positionX, positionY);
            Console.Write("[");
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defoultColor;

            bar = "";
            for (int i = nowBar; i < maxBar; i++)
            {
                bar += "_";
            }
            Console.Write(bar + "]");

        }
    }
}
