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
    }
}
