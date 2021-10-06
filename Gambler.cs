using System;
using System.Collections.Generic;
using System.Text;

namespace GamblerProbWorkshop
{
    public class Gambler
    {
        public const int STACK = 100;
        public const int BET = 1;
        public const int LOOSE_AMOUNT = 1;
        public const int WIN_AMOUNT = 1;
        public const int WIN_TOTAL = 150;
        public const int LOOSE_TOTAL = 50;
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
        public static void winOrLooseByPercentage()
        {
            int winStak = STACK;
            int looseStak = STACK;
            while (winStak < WIN_TOTAL && looseStak > LOOSE_TOTAL)
            {
                Random random = new Random();
                int betCheck = random.Next(0, 2);
                if(betCheck == 1)
                {
                    winStak += WIN_AMOUNT;
                }
                else
                {
                    looseStak -= LOOSE_AMOUNT;
                }
            }
            if(looseStak == 150)
            {
                Console.WriteLine("Won the game");
            }
            else
            {
                Console.WriteLine("Lost the Game");
            }
        }
    }
}
