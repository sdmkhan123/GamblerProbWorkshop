using System;
using System.Collections.Generic;
using System.Text;

namespace GamblerProbWorkshop
{
    public class Gambler
    {
        public const int STACK = 100;
        public const int BET = 1;
        public static void winOrLoose()
        {
            Random random = new Random();
            int betCheck = random.Next(0, 2);
            if (betCheck == 1)
            {
                Console.WriteLine("Won");
            }
            else
            {
                Console.WriteLine("Loose");
            }
        }
        public static void winOrLooseByFifty()
        {
            int totalStack = STACK;
            int winPer = 0;
            int loosePer = 0;
            while (totalStack < 150 && totalStack > 50)
            {
                Random random = new Random();
                int betCheck = random.Next(0, 2);
                if(betCheck == 1)
                {
                    totalStack += BET;
                }
                else
                {
                    totalStack -= BET;
                }
                winPer = (totalStack / STACK) * 100;
                loosePer = (totalStack / STACK) * 100;
            }
            if(totalStack == 150)
            {
                Console.WriteLine("Won the game");
            }
            else
            {
                Console.WriteLine("Lost the Game");
            }
            Console.WriteLine(totalStack);
        }
    }
}
