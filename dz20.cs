using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace dz17
{
    class dz20
    {
        static void Main(string[] args)
        {
            DrawBar(60, 100, 5, 5, ConsoleColor.Red);
        }
        static void DrawBar(int value, int maxValue, int positionX, int positionY, ConsoleColor color)
        {
            int maxBar = 10;
            int nowBar = value / (maxValue / 10);


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
            Console.Write(bar+"]");

        }

    }
}
