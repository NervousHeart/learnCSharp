using System;

namespace dz1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("О нет! После отчаянной обороны от инопланетных захватчиков" +
                "\nи финальной битвой против генерала пришельцев вы оказались ранены!" +
                "\n\nКровь! Повсюду ваша кровь! Вы буквально видите как ваша жизнь утекает сквозь пальцы!" +
                "\n\nНо чудо, рядом находится больница, вы заходите туда в надежде на спасение.");


            Console.WriteLine("\nВнутри больницы вы видете очередь из бабулек и понимаете, что сквозь них вам не пробиться." +
                "\nОстается только ждать своей очереди. Вы подсчитали, что одна бабулька находится на приеме 10 минут, а впереди вас: ");
            int doctorAppointment = 10;
            Console.WriteLine("\nВведите количество бабулек:");
            int valueGrandMothers = Convert.ToInt32(Console.ReadLine());
            int waitingTime = valueGrandMothers * doctorAppointment;
            int hourWait = waitingTime / 60;
            int minuteWait = waitingTime % 60;
            Console.WriteLine($"\nСделав нехитрые вычисления, вы понимаете, что вам нужно продержаться {hourWait} часа(ов) и {minuteWait} минут." +
                $"\n\nОстается надеяться, что вы сможете дожить до приема.");


                
            
        }
    }
}
