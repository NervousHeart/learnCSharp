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
            bool preparationBigBoom = false;
            int spellPreparation = 100;
            int spellPunchStaff = 150;
            Random rand = new Random();

            do
            {

                int damageBoss = rand.Next(200, 250);
                int spellForceTroll = rand.Next(400, 600);
                int spellHeal = rand.Next(150, 300);
                int spellGreatBoom = rand.Next(600, 1500);
                int spell = rand.Next(1, 4);
                int spellShield = rand.Next(100, 200);


                if (hpMage < 200)
                {
                    hpMage += spellHeal;
                    Console.WriteLine($"Маг закрывает себя магическим щитом на {spellShield} и лечит себя на {spellHeal} жизней");
                    damageBoss -= spellShield;
                }
                else
                {
                    if (spell == 1)
                    {
                        hpBoss -= spellForceTroll;
                        Console.WriteLine($"Маг использует силу Тролля! И наносит боссу {spellForceTroll} урона");
                    }
                    else if (spell == 2 && preparationBigBoom == false)
                    {
                        hpMage -= spellPreparation;
                        preparationBigBoom = true;
                        Console.WriteLine($"Маг готовит заклинание! И жертвует {spellPreparation} очков своей жизни");
                    }
                    else if (spell == 3 && preparationBigBoom == true)
                    {
                        hpBoss -= spellGreatBoom;
                        preparationBigBoom = false;
                        Console.WriteLine($"Маг кастует огромный взрыв! И наносит {spellGreatBoom} урона боссу!");
                    }
                    else if (spell == 2 && preparationBigBoom == true)
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
