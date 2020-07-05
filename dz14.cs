using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hpMage = 1000;
            int hpBoss = 3000;
            bool flag = false;
            int spellpreparation = 100;
            int spellPunchStaff = 150;
            Random rand = new Random();
            Random strike = new Random();

            do
            {

                int damageBoss = rand.Next(150, 200);
                int spellForceTroll = rand.Next(400, 600);
                int spellHeal = rand.Next(250, 300);
                int spellGreatBoom = rand.Next(600, 1500);
                int spell = rand.Next(1, 4);


                if (hpMage < 200)
                {
                    hpMage += spellHeal;
                    Console.WriteLine($"Маг лечит себя на {spellHeal} жизней");
                }
                else
                {
                    if (spell == 1)
                    {
                        hpBoss -= spellForceTroll;
                        Console.WriteLine($"Маг использует силу Тролля! И наносит боссу {spellForceTroll} урона");
                    }
                    else if (spell == 2 && flag == false)
                    {
                        hpMage -= spellpreparation;
                        flag = true;
                        Console.WriteLine($"Маг готовит заклинание! И жертвует {spellpreparation} очков своей жизни");
                    }
                    else if (spell == 3 && flag == true)
                    {
                        hpBoss -= spellGreatBoom;
                        flag = false;
                        Console.WriteLine($"Маг кастует огромный взрыв! И наносит {spellGreatBoom} урона боссу!");
                    }
                    else if (spell == 2 && flag == true)
                    {
                        hpBoss -= spellPunchStaff;
                        Console.WriteLine($"Маг не успевает применить заклинание взрыва и поэтому бьет босса посохом на {spellPunchStaff} урона");
                    }

                }

                    hpMage -= damageBoss;
                    Console.WriteLine($"Босс наносит {damageBoss} урона магу");
                    Console.WriteLine($"HPBOSS = {hpBoss}" +
                        $"\nHPMAGE = {hpMage}");

            } while (hpBoss > 0 && hpMage > 0);

            if (hpBoss<0)
            {
                Console.WriteLine("Маг победил!");
            }
            else
            {
                Console.WriteLine("Босс одолел мага!");
            }
        }
    }
}