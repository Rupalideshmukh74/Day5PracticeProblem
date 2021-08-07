using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionProblem
{
    class FlipCoin
    {
        public static double FindPercentageOfHeads(int numberOfTimeCoinTossed)
        {
            Random rand = new Random();
            double headsCount = 1;
            int HEADS = 1;
            for (int i = 0; i < numberOfTimeCoinTossed; i++)
            {
                int coinTossed = rand.Next(0, 2);
                if (coinTossed == HEADS)
                {
                    Console.WriteLine("Heads");
                    headsCount++;
                }
                else
                {
                    Console.WriteLine("Tails");
                }

            }
            return (headsCount / numberOfTimeCoinTossed) * 100;
        }
        public static double FindPercentageOfTails(double headsPercentage)
        {
            return 100 - headsPercentage;
        }

    }

}
        

        
    